﻿using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class DetailsViewForm : Form {
        public DetailsViewForm(string content) {
            InitializeComponent();
            rtboxDetails.Text = content;
        }

        private void DetailsViewForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}
