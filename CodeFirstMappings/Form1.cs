using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstMappings
{
    public partial class Form1 : Form
    {
        Action[] actions;
        ChessCompetitionsDB data = new ChessCompetitionsDB();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActionsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView4.ReadOnly = true;
            ActionsCombo.Items.AddRange(new string[] {"Show soon tournaments","Show champions","Show undone tournaments","Show winners in this competition","Show competition with most participants" });
            ActionsCombo.SelectedIndex = 0;
            actions = new Action[5] {ShowSoonComp,ShowChamps,ShowUnDone,ShowWinnersInSuch,ShowCompWithMostParts };
            
        }

        internal class ChessCompetitionsDB : DbContext
        {
            public ChessCompetitionsDB() : base("ChessCompetitions") { }
            public virtual DbSet<Participant> Participant { get; set; }
            public virtual DbSet<Competition> Competition { get; set; }
            public virtual DbSet<Result> Results { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new ParticipantMap());
                modelBuilder.Configurations.Add(new CompetitionMap());
                modelBuilder.Configurations.Add(new ResultMap());
                base.OnModelCreating(modelBuilder);
            }
        }

        internal class Participant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Birth { get; set; }
            public string Country { get; set; }
            public float Weight { get; set; }
            public float Height { get; set; }

            public virtual ICollection<Result> Results { get; set; }
        }

        internal class Competition
        {
            public int Id { get; set; }
            public string CompetitionName { get; set; }
            public DateTime Date { get; set; }
            public string City { get; set; }

            public virtual ICollection<Result> Results { get; set; }
        }

        internal class Result
        {
            public int Id { get; set; }
            public int Place { get; set; }
            public virtual Competition Competition { get; set; }
            public virtual Participant Participant { get; set; }

        }

        private void ShowSoonComp()
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = data.Competition.Where(x => x.Date > DateTime.Now).ToList();
            tabControl1.SelectedIndex = 3;
        }

        private void ShowChamps()
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = data.Participant.Where(x=>x.Results.Where(q=>q.Place==1).Count()>0);
            tabControl1.SelectedIndex = 3;
        }

        private void ShowUnDone()
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = data.Competition.Where(x => x.Date > DateTime.Now).ToList();
            tabControl1.SelectedIndex = 3;
        }

        private void ShowWinnersInSuch()
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = data.Participant.Where(x => x.Results.Where(q => q.Place <= 3&&q.Competition.CompetitionName==textBox1.Text).Count() > 0);
            tabControl1.SelectedIndex = 3;
        }

        private void ShowCompWithMostParts()
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = data.Competition.OrderByDescending(x=>x.Results.Count).Take(1);
            tabControl1.SelectedIndex = 3;
        }

        private void AddCompetBtn_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Name=="CompetitionsPage")
            {
                if (NameTextBoxCompet.TextLength == 0||CityTextBoxCompet.TextLength==0)
                    return;
                Competition c = new Competition()
                {
                    CompetitionName = NameTextBoxCompet.Text,
                    Date = DateCompetPicker.Value,
                    City = CityTextBoxCompet.Text,
                };
                data.Competition.Add(c);
                try
                {
                    data.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Wrong parameter!");
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data.Competition.ToList();
            }
            else if (tabControl1.SelectedTab.Name == "ResultsPage")
            {
                if (PlacePicker.Value == 0 || CompetitionIdPicker.Value == 0||PartIdPicker.Value==0)
                    return;
                Result c = new Result()
                {
                    Competition = data.Competition.Find((int)CompetitionIdPicker.Value),
                    Place = (int)PlacePicker.Value,
                    Participant = data.Participant.Find((int)PartIdPicker.Value),
                };
                data.Results.Add(c);
                try
                {
                    data.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Wrong parameter!");
                }
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = data.Results.ToList();
            }
            else if (tabControl1.SelectedTab.Name == "ParticipantsPage")
            {
                if (NameTextBoxPart.TextLength == 0 || CountryTextBoxPart.TextLength == 0||WeightPicker.Value==0|| HeightPicker.Value==0)
                    return;
                Participant c = new Participant()
                {
                    Name = NameTextBoxPart.Text,
                    Birth = BirthPicker.Value,
                    Country = CountryTextBoxPart.Text,
                    Weight= (int)WeightPicker.Value,
                    Height= (int)HeightPicker.Value,
                };
                data.Participant.Add(c);
                try
                {
                    data.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Wrong parameter!");
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = data.Participant.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Competitions": dataGridView1.SelectAll(); dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Competition.AddOrUpdate(x.DataBoundItem as Competition)); data.SaveChanges(); dataGridView1.DataSource = null; dataGridView1.DataSource = data.Competition.ToList(); dataGridView1.ClearSelection(); break;
                case "Participants": dataGridView2.SelectAll(); dataGridView2.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Participant.AddOrUpdate(x.DataBoundItem as Participant)); data.SaveChanges(); dataGridView2.DataSource = null; dataGridView2.DataSource = data.Participant.ToList(); dataGridView2.ClearSelection(); break;
                case "Results": dataGridView3.SelectAll(); dataGridView3.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Results.AddOrUpdate(x.DataBoundItem as Result)); data.SaveChanges(); dataGridView3.DataSource = null; dataGridView3.DataSource = data.Results.ToList(); dataGridView3.ClearSelection(); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Competitions": dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Competition.Remove(x.DataBoundItem as Competition)); data.SaveChanges(); dataGridView1.DataSource = null; dataGridView1.DataSource = data.Competition.ToList(); dataGridView1.ClearSelection(); break;
                case "Participants": dataGridView2.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Participant.Remove(x.DataBoundItem as Participant)); data.SaveChanges(); dataGridView2.DataSource = null; dataGridView2.DataSource = data.Participant.ToList(); dataGridView2.ClearSelection(); break;
                case "Results": dataGridView3.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Results.Remove(x.DataBoundItem as Result)); data.SaveChanges(); dataGridView3.DataSource = null; dataGridView3.DataSource = data.Results.ToList(); dataGridView3.ClearSelection(); break;
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (ActionsCombo.SelectedIndex == 3 && textBox1.TextLength == 0)
                return;
            actions[ActionsCombo.SelectedIndex]();
        }

        private void ActionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ActionsCombo.SelectedIndex==3)
            {
                textBox1.Visible = true;
            }
            else
                textBox1.Visible = false;
        }
    }
}
