using System.Drawing;
using System.Windows.Forms;

namespace DynamicSecurityMonitor
{
    public partial class StatusCard : UserControl
    {
        // Public properties to allow customization from the main form
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public Image Icon
        {
            get => pbIcon.Image;
            set => pbIcon.Image = value;
        }

        public StatusCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the card's appearance based on the security status.
        /// </summary>
        /// <param name="isSecure">True if the status is good, False if there's an issue.</param>
        /// <param name="statusText">The text to display (e.g., "On", "Off", or a detailed status).</param>
        public void UpdateStatus(bool isSecure, string statusText)
        {
            lblStatus.Text = statusText;

            if (isSecure)
            {
                // Set to a secure/enabled state
                this.BackColor = Color.FromArgb(220, 235, 250); // Light Blue
                lblStatus.ForeColor = Color.FromArgb(0, 100, 180); // Dark Blue
                lblTitle.ForeColor = Color.Black;
            }
            else
            {
                // Set to an insecure/disabled state
                this.BackColor = Color.FromArgb(255, 220, 220); // Light Red
                lblStatus.ForeColor = Color.Firebrick;
                lblTitle.ForeColor = Color.Black;
            }
        }
    }
}
