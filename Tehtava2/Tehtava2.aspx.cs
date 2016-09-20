using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava2 : System.Web.UI.Page
{
    BLLotto lotto = new BLLotto();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (rivit.Items.Count == 0)
        {
            for (int i = 0; i < 21; i++)
            {
                rivit.Items.Add(new ListItem(Convert.ToString(i)));
            }
        }
    }

    protected void haeRivit_Click(object sender, EventArgs e)
    {
        if (tyyppi.SelectedValue == "Lotto")
        {
            test.Text = lotto.TeeLotto(Convert.ToInt32(rivit.SelectedValue));
        }
        else if(tyyppi.SelectedValue == "ViikingLotto")
        {
            test.Text = lotto.TeeVikingLotto(Convert.ToInt32(rivit.SelectedValue));
        }
    }
}