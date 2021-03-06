﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SQLIndexManager.Properties;

namespace SQLIndexManager {

  public partial class ErrorBox : XtraForm {

    public ErrorBox(Exception ex) {
      InitializeComponent();

      edError.Text =
        "Application has encountered an unexpected error" +
        $"{Environment.NewLine}Please send error detail to {Resources.GitHubLink}" +
        $"{Environment.NewLine}Build: {AppInfo.Version}" +
        $"{Environment.NewLine}OS: {Environment.OSVersion}" +
        $"{Environment.NewLine}{Environment.NewLine}{ex.Message}" +
        $"{Environment.NewLine}{ex.Source}" +
        $"{Environment.NewLine}{ex.StackTrace}";
    }

    #region Override Methods

    protected override bool ProcessDialogKey(Keys keyData) {
      if (keyData == Keys.Escape) {
        Close();
        return true;
      }

      return base.ProcessDialogKey(keyData);
    }

    #endregion

  }

}
