﻿// ------------------------------------------------------------------
// Copyright (C) 2011-2016 Maruko Toolbox Project
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied.
// See the License for the specific language governing permissions
// and limitations under the License.
// -------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ControlExs
{

    /****************************************************************
    * 
    *           Author：苦笑
    *             Blog: http://www.cnblogs.com/Keep-Silence-/
    *             Date: 2013-2-22
    *
    *****************************************************************/


    /// <summary>
    /// 拥有ToolTip属性的Form基类
    /// </summary>
    public class FormBase : Form
    {
        private ToolTip _toolTip;

        public FormBase()
            : base()
        {
            _toolTip = new ToolTip();
        }

        public ToolTip ToolTip
        {
            get { return _toolTip; }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                _toolTip.Dispose();
            }
            _toolTip = null;
        }

        protected String GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        protected void ShowErrorMessage(String argMessage)
        {
            MessageBox.Show(argMessage, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ShowErrorMessage(String argMessage, String argTitle)
        {
            MessageBox.Show(argMessage, argTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ShowWarningMessage(String argMessage)
        {
            MessageBox.Show(argMessage, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ShowWarningMessage(String argMessage, String argTitle)
        {
            MessageBox.Show(argMessage, argTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ShowInfoMessage(String argMessage)
        {
            MessageBox.Show(argMessage, "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowInfoMessage(String argMessage, String argTitle)
        {
            MessageBox.Show(argMessage, argTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected DialogResult ShowQuestion(String argQuestion, String argTitle)
        {
            return MessageBox.Show(argQuestion, argTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
