using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterPost
{
    public partial class FormTwitterPost : Form
    {
        public FormTwitterPost()
        {
            InitializeComponent();
        }

        private CoreTweet.OAuth.OAuthSession Session;
        private void butAuthorize_Click(object sender, EventArgs e)
        {
            Session = CoreTweet.OAuth.Authorize("", "");
            System.Diagnostics.Process.Start(this.Session.AuthorizeUri.ToString());
        }

        private CoreTweet.Tokens tokens;
        private void butPIN_Click(object sender, EventArgs e)
        {
            tokens = CoreTweet.OAuth.GetTokens(Session, txtPIN.Text);
        }

        private void butTweet_Click(object sender, EventArgs e)
        {
            tokens.Statuses.Update(txtTweet.Text);
        }
    }
}
