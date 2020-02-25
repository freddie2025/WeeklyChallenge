using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PillReminderUI
{
    public partial class ReminderWindow : Form
    {
        BindingList<PillModel> medications = new BindingList<PillModel>();
        BindingList<PillModel> pillsToTake = new BindingList<PillModel>();
        readonly Timer _timer;

        public ReminderWindow()
        {
            InitializeComponent();

            allPillsListBox.DataSource = medications;
            allPillsListBox.DisplayMember = "PillInfo";

            pillsToTakeListBox.DataSource = pillsToTake;
            pillsToTakeListBox.DisplayMember = "PillInfo";

            PopulateDummyData();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += OnTimerElapsed;
            _timer.Start();
        }


        private void PopulateDummyData()
        {
            medications.Add(new PillModel { PillName = "The white one", TimeToTake = DateTime.ParseExact("0:15 am", "h:mm tt", null, System.Globalization.DateTimeStyles.AssumeLocal) });
            medications.Add(new PillModel { PillName = "The big one", TimeToTake = DateTime.Parse("8:00 am") });
            medications.Add(new PillModel { PillName = "The red ones", TimeToTake = DateTime.Parse("11:45 pm") });
            medications.Add(new PillModel { PillName = "The oval one", TimeToTake = DateTime.Parse("0:27 am") });
            medications.Add(new PillModel { PillName = "The round ones", TimeToTake = DateTime.Parse("6:15 pm") });
        }

        private void PopulatePillsToTakeList()
        {
            var pills = medications
                .Where(x => x.TimeToTake.TimeOfDay <= DateTime.Now.TimeOfDay)
                .Where(x => x.LastTaken.Date < DateTime.Now.Date)
                .OrderBy(x => x.TimeToTake).ToList();
            pillsToTake.Clear();
            pills.ForEach(x => pillsToTake.Add(x));
        }

        private void takePill_Click(object sender, EventArgs e)
        {
            PillModel selectedPill = (PillModel)pillsToTakeListBox.SelectedItem;

            selectedPill.LastTaken = DateTime.Now;
        }

        private void refreshPillsToTake_Click(object sender, EventArgs e)
        {
            PopulatePillsToTakeList();
        }

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            var pills = medications
                .Where(x => x.TimeToTake.TimeOfDay <= DateTime.Now.TimeOfDay)
                .Where(x => x.LastTaken.Date < DateTime.Now.Date)
                .OrderBy(x => x.TimeToTake).ToList();

            foreach (PillModel pill in pills)
            {
                if (pillsToTake.Contains(pill) == false)
                {
                    pillsToTake.Add(pill);
                }
            }

            for (int i = pillsToTake.Count -1; i >= 0; i--)
            {
                if (pills.Contains(pillsToTake[i]) == false)
                {
                    pillsToTake.RemoveAt(i);
                }
            }

            //foreach (PillModel pill in pillsToTake.ToList())
            //{
            //    if (pills.Contains(pill) == false)
            //    {
            //        pillsToTake.Remove(pill);
            //    }
            //}
        }
    }
}
