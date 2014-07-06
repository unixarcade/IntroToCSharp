using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class AccountEditForm : System.Windows.Forms.Form
{
    private Label nameLabel;
    private TextBox nameTextBox;
    private Button finishButton;

    IAccount account;

    public AccountEditForm (IAccount inAcount)
    {
        this.account = inAccount;

        this.nameLabel = new Label();
        this.nameLabel.Text="Name";
        this.nameLabel.Top=50;
        this.nameLabel.Left=0;
        this.Controls.Add(this.nameLabel);

        this.nameTextBox = new TextBox();
        this.nameTextBox.Top=50;
        this.nameTextBox.Left=100;
        this.nameTextBox.Text = this.account.GetNAme();
        this.Controls.Add(this.nameTextBox);

        this.finishButton = new Button();
        this.finishButton.Top=80;
        this.finishButton.Left=100;
        this.finishButton.Text="Finished";
        this.finishButton.Click += new System.EventHandler(finishButton_Click);
        this.Controls.Add(this.finishButton);


    }
private void finishButton_Click(object sender, System.EventArgs e)
{
    string reply = account.ValidateName(nameTextBox.Text);
    if (reply.Length > 0){
        System.Windows.Forms.MessageBox.Show(reply);
    return;
    }

    this.account.SetName(nameTextBox.Text);
    this.Dispose();

}
}