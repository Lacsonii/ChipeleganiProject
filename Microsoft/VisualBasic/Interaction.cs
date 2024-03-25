using System;
using System.Windows.Forms;

namespace Microsoft.VisualBasic
{
    internal class Interaction
    {
        public static string InputBox(string prompt, string title, string defaultText)
        {
            using (Form inputForm = new Form())
            {
                Label label = new Label { Left = 20, Top = 20, Text = "Please enter OTP sent to your number" };
                TextBox textBox = new TextBox { Left = 20, Top = 50, Width = 180, Text = defaultText };
                Button okButton = new Button { Text = "OK", Left = 20, Width = 80, Top = 80 };
                Button cancelButton = new Button { Text = "Cancel", Left = 120, Width = 80, Top = 80 };

                okButton.Click += (sender, e) => inputForm.DialogResult = DialogResult.OK;
                cancelButton.Click += (sender, e) => inputForm.DialogResult = DialogResult.Cancel;

                inputForm.Text = title;
                inputForm.Controls.Add(label);
                inputForm.Controls.Add(textBox);
                inputForm.Controls.Add(okButton);
                inputForm.Controls.Add(cancelButton);

                inputForm.AcceptButton = okButton;
                inputForm.CancelButton = cancelButton;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return textBox.Text;
                }
                else
                {
                    return string.Empty; // User canceled the input
                }
            }
        }
    }

}
