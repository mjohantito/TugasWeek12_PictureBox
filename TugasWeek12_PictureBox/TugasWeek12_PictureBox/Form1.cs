using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TugasWeek12_PictureBox
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=premier_league;";
        string sqlQuery;

        public static string playernamee;
        DataTable dtPlayer = new DataTable();
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtListTeam = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select team_id, team_name from team";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListTeam);

                cboxTim.DataSource = dtListTeam;
                cboxTim.DisplayMember = "team_name";
                cboxTim.ValueMember = "team_id";
                cboxTim.SelectedIndex = 0;

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loaddata()
        {
            try
            {
                if(tboxNamaPlayer.Text == "")
                {
                    DataTable dtPlayer = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "select player_name as `Nama Pemain`, nation as `Asal Negara`, if(`status` = '1','Aktif','Tidak Aktif') as `Status` from pemain p, nationality n where n.nationality_id = p.nationality_id and team_id = '" + cboxTim.SelectedValue.ToString() + "' ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);

                    dgvPlayer.DataSource = dtPlayer;
                }
                else
                {
                    DataTable dtPlayer = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "select player_name as `Nama Pemain`, nation as `Asal Negara`, if(`status` = '1','Aktif','Tidak Aktif') as `Status` from pemain p, nationality n where n.nationality_id = p.nationality_id and team_id = '" + cboxTim.SelectedValue.ToString() + "' and player_name LIKE '"+tboxNamaPlayer.Text+"%' ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);

                    dgvPlayer.DataSource = dtPlayer;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxNamaPlayer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                playernamee = dgvPlayer.Rows[e.RowIndex].Cells["Nama Pemain"].Value.ToString();
                var formEdit1 = new formEditPlayer();
                formEdit1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMainMenu_Activated(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
