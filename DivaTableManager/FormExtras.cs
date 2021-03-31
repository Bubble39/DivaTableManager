﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Windows.Forms;

public class FormExtras
{
    public static void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }

    public static void informationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("DivaTableManager by Jay39w" + Environment.NewLine + "Thanks to all who helped me with learning C#!" + Environment.NewLine + "Current Version: v1.0 (31/03/2021)", "About DTM");
    }

    public static void moduleTableHelpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This program accepts gm_module_id.bin files and allows the user to edit them." + Environment.NewLine + Environment.NewLine +
            "If you do not have a gm_module_id.bin file, please extract it from mdata_gm_module_tbl.farc or gm_module_tbl.farc files using FarcPack or MikuMikuModel (by Skyth)" + Environment.NewLine + Environment.NewLine +
            "Please hover over any of the property names to find out more information about them." + Environment.NewLine + Environment.NewLine +
            "If you are still struggling, you can contact me for help at POI39#7310 on Discord.", "Help");
    }

    public static void mentalHelpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You can do this!", "Mental Help");
    }

    public static void characterItemTableHelpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not yet implemented." + Environment.NewLine + "Please wait patiently.", "Help");
    }
}