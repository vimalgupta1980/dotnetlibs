using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using SysconCommon.Common;

namespace SysconCommon.GUI
{
    public static class ComboBoxExtenstions
    {
        public static void SelectItem<T>(this ComboBox self, Func<T, bool> finder)
        {
            foreach (var i in FunctionalOperators.Range(self.Items.Count))
            {
                if (finder((T)self.Items[i]))
                {
                    self.SelectedIndex = i;
                    return;
                }
            }

            self.SelectedIndex = 0;
        }

        public static void AddList<T>(this ComboBox self, IEnumerable<T> lst)
        {
            foreach (var i in lst)
            {
                self.Items.Add(i);
            }
        }
    }
}
