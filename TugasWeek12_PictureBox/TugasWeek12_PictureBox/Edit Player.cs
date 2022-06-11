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
using System.IO;

namespace TugasWeek12_PictureBox
{
    public partial class formEditPlayer : Form
    {
        public formEditPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=premier_league;";
        string sqlQuery;

        string playernamee = FormMainMenu.playernamee;
        string statuss;
        private void formEditPlayer_Load(object sender, EventArgs e)
        {
            try
            {
                //isi cbox
                DataTable dtListTeam = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select team_id, team_name from team";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListTeam);

                cboxTeam.DataSource = dtListTeam;
                cboxTeam.DisplayMember = "team_name";
                cboxTeam.ValueMember = "team_id";

                DataTable dtAsalNeg = new DataTable();
                sqlQuery = "select nationality_id, nation from nationality";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAsalNeg);

                cboxNation.DataSource = dtAsalNeg;
                cboxNation.DisplayMember = "nation";
                cboxNation.ValueMember = "nationality_id";

                DataTable dtPPos = new DataTable();
                sqlQuery = "select playing_pos from player group by playing_pos";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPPos);

                cboxPlayingPos.DataSource = dtPPos ;
                cboxPlayingPos.DisplayMember = "playing_pos";
                cboxPlayingPos.ValueMember = "playing_pos";




                DataTable dtPemain = new DataTable();
                sqlQuery = "select player_id, team_number,player_name,team_id, nationality_id, playing_pos, `status` from pemain where player_name = '"+playernamee+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPemain);

                tboxPlayerName.Text = dtPemain.Rows[0]["player_name"].ToString();
                cboxTeam.SelectedValue = dtPemain.Rows[0]["team_id"].ToString();
                cboxNation.SelectedValue = dtPemain.Rows[0]["nationality_id"].ToString();
                cboxPlayingPos.SelectedValue = dtPemain.Rows[0]["playing_pos"].ToString();

                if(dtPemain.Rows[0]["status"].ToString() == "1")
                {
                    rbutAktif.Checked = true;
                    statuss = "1";
                }
                else if (dtPemain.Rows[0]["status"].ToString() == "0")
                {
                    rbutTidakAktif.Checked = true;
                    statuss = "0";
                }
                // nge load gambar pas form load
                DataTable dtgambar = new DataTable();
                sqlQuery = "select url from pemain where player_name = '"+playernamee+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtgambar);
                byte[] img = (byte[])dtgambar.Rows[0][0];

                MemoryStream msoi = new MemoryStream(img);
                pbProfile.Image = Image.FromStream(msoi);
                sqlAdapter.Dispose();


            }
            catch (Exception)
            {

            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Choose Image(*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    pbProfile.Image = Image.FromFile(openfile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butOKE_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(rbutAktif.Checked == true)
                {
                    statuss = "1";
                }
                else if(rbutTidakAktif.Checked == true)
                {
                    statuss = "0";
                }
                sqlConnect = new MySqlConnection(connectString);
                //tambahan
                MemoryStream msoi = new MemoryStream();
                pbProfile.Image.Save(msoi, pbProfile.Image.RawFormat);
                byte[] img = msoi.ToArray();

                //msoi, img -> variable
                sqlQuery = "update pemain set team_id = '" + cboxTeam.SelectedValue.ToString() + "', nationality_id = '" + cboxNation.SelectedValue.ToString() + "', playing_pos = '" + cboxPlayingPos.SelectedValue.ToString() + "', `status` = '"+statuss+"', url = @img where player_name = '"+playernamee+"' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                //sqlCommand.ExecuteNonQuery();
                //tambahan 2
                sqlCommand.Parameters.Add("@img", MySqlDbType.Blob);
                sqlCommand.Parameters["@img"].Value = img;

                if(sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Berhasil DiUpdate");
                }
                sqlConnect.Close();
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }
    }
}
