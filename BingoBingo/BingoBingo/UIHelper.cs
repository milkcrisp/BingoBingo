using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class UIHelper
{
    public void UpdateLabels(List<Label> labels, List<int> selectedNumbers, int lastNumber)
    {
        foreach (Label label in labels)
        {
            int number = int.Parse(label.Text);
            if (selectedNumbers.Contains(number))
            {
                label.ForeColor = Color.Red;
                label.Font = new Font(label.Font, FontStyle.Bold);
                label.BackColor = Color.White;

                if (number == lastNumber)
                {
                    label.ForeColor = Color.Red;
                    label.BackColor = Color.Orange;
                }
            }
            else
            {
                label.ForeColor = SystemColors.ControlText;
                label.Font = new Font(label.Font, FontStyle.Regular);
                label.BackColor = Color.White;
            }
        }
    }
}
