using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.GUI;

namespace ZiCoffe.Items
{
    public static class MessageBoxItems
    {
        public static System.Windows.Forms.DialogResult ShowMyMessage(Image image, string description)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;

            using (formCustomMessage f = new formCustomMessage())
            {
                f.Picture = image;
                f.Description = description;
                dialogResult = f.ShowDialog();
            }

            return dialogResult;
        }
    }
}
