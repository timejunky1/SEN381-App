using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public partial class LogIn : Form
    {
        
        private LoginController loginController;
        public LogIn()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginController.Connect();

            // Modify the appearance of textboxes and buttons
            ModifyControlAppearances(UserName_txt, Color.White, Color.FromArgb(27, 77, 137));
            ModifyControlAppearances(Password_txt, Color.White, Color.FromArgb(27, 77, 137));
            ModifyControlAppearances(Login_btn, Color.FromArgb(249, 228, 91), Color.FromArgb(249, 228, 91));
            ModifyControlAppearances(Exit_btn, Color.FromArgb(230, 73, 73), Color.FromArgb(230, 73, 73));
        }

        private void ModifyControlAppearances(Control control, Color backgroundColor = default(Color), Color borderColor = default(Color))
        {
            if (control is Button)
            {
                Button button = (Button)control;
                // Modify the appearance of buttons
                int borderRadius = 7;
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Top left corner
                path.AddArc(button.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Top right corner
                path.AddArc(button.Width - borderRadius * 2, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Bottom right corner
                path.AddArc(0, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Bottom left corner
                path.CloseFigure();
                button.Region = new Region(path);

                // Set button background color and border color
                button.BackColor = backgroundColor != default(Color) ? backgroundColor : Color.FromArgb(27, 77, 137);
                button.FlatAppearance.BorderColor = borderColor != default(Color) ? borderColor : button.BackColor;
                button.FlatStyle = FlatStyle.Flat;
            }
            else if (control is TextBox)
            {
                // Modify the appearance of textboxes
                TextBox textBox = (TextBox)control;
                int borderWidth = 2;

                // Set textbox border color and background color
                textBox.BackColor = backgroundColor != default(Color) ? backgroundColor : Color.FromArgb(27, 77, 137);
                textBox.ForeColor = Color.Black; // Text color for textboxes
                textBox.BorderStyle = BorderStyle.None; // Set the border style to None
                textBox.BackColorChanged += (sender, e) =>
                {
                    textBox.Invalidate(); // Force the textbox to repaint when the background color changes
                };

                // Set textbox border color and add rounded corners
                if (borderColor != default(Color))
                {
                    textBox.Paint += (sender, e) =>
                    {
                        using (Pen pen = new Pen(borderColor, borderWidth))
                        {
                            e.Graphics.DrawRectangle(pen, 0, 0, textBox.Width - 1, textBox.Height - 1);
                        }
                    };
                }
            }
        }


        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = UserName_txt.Text;
            string password = Password_txt.Text;

            loginController.HandleLoginButtonClick(username, password, this, WelcomeLabel_txt);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
