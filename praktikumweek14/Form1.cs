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

namespace praktikumweek14
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtTeam2 = new DataTable();
        DataTable dtTeam3 = new DataTable();
        DataTable match = new DataTable();
        int PosisiSekarang = 0;
        string simpan;

        private void FormTeam_Load(object sender, EventArgs e)
        {

            sqlQuery = "SELECT t.team_name, concat (m.manager_name, '( ', n.nation, ' )'), concat(t.home_stadium, ' , ' ,t.city, '(', t.capacity , ')'), t.team_id from team t ,manager m , nationality n, dmatch d where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id and t.team_id= d.team_id group by 1 order by 1 ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

           
            IsiDataTeam(0);

           
        }
        public void IsiDataTeam(int Posisi)
        {
            try
            {
                laTeamName.Text = dtTeam.Rows[Posisi][0].ToString();
                laManager.Text = dtTeam.Rows[Posisi][1].ToString();
                laStadium.Text = dtTeam.Rows[Posisi][2].ToString();
                simpan = dtTeam.Rows[Posisi][3].ToString();
                dtTeam2 = new DataTable();
                dtTeam3 = new DataTable();
                match = new DataTable();

                //top score
                sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='GO',1 , if(d.`type` = 'GP', 1, 0 ))) , SUM(if(d.`type` = 'GP', 1, 0))    from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + simpan + "' group by p.player_id order by 2 desc";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeam2);

                    
                //worst score
                sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='CR',1,0)) , SUM(if(d.`type` = 'CY', 1, 0)) ,  sum(if(d.type = 'CY',1,0)) + sum(if(d.type = 'CR',3,0)) as 'poin'  from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + simpan + "' group by p.player_id order by poin desc; ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeam3);



                laTopScorer.Text = dtTeam2.Rows[0][0].ToString() + " " + dtTeam2.Rows[0][1].ToString() + " (" + dtTeam2.Rows[0][2].ToString() + " )";

                laWorst.Text = dtTeam3.Rows[0][0].ToString() + " ," + dtTeam3.Rows[0][2].ToString() + " Yellow Card and " + dtTeam3.Rows[0][1].ToString() + " Red Card";


                PosisiSekarang = Posisi;

                //data grid view

                sqlQuery = "select m.match_date ,date_format(m.match_date, \'%d/%c/%Y') as 'Match_Date', 'HOME' as 'home/away', concat('vs ',t.team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'Score' from `match` m, team t where team_home = '" + simpan + "' and m.team_away = t.team_id union select m.match_date ,date_format(m.match_date, \'%d/%c/%Y') as 'match date', 'AWAY' as 'Home/Away', concat('vs ',t.team_name) as 'Lawan', concat(goal_home, ' - ', goal_away) as 'Score' from `match` m, team t where team_away = '" + simpan + "' and m.team_home = t.team_id order by 1 desc limit 5;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(match);
                GridMatch.DataSource = match;
                GridMatch.Columns.Remove("match_date");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            IsiDataTeam(0);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataTeam(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Team Sudah Team Pertama");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeam.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataTeam(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Team Sudah Team Terakhir");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            IsiDataTeam(dtTeam.Rows.Count - 1);


        }
    }
}
