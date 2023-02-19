
namespace JadeGo
{
    partial class TheBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowHttpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSearchEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckDuckGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.webViewMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.back = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.Reload_Anim_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(944, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(31, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.allowHttpToolStripMenuItem,
            this.selectSearchEngineToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(23, 20);
            this.toolStripMenuItem1.Text = "⋮";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // allowHttpToolStripMenuItem
            // 
            this.allowHttpToolStripMenuItem.Name = "allowHttpToolStripMenuItem";
            this.allowHttpToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.allowHttpToolStripMenuItem.Text = "Allow http";
            this.allowHttpToolStripMenuItem.Click += new System.EventHandler(this.allowHttpToolStripMenuItem_Click);
            // 
            // selectSearchEngineToolStripMenuItem
            // 
            this.selectSearchEngineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.duckDuckGoToolStripMenuItem,
            this.bingToolStripMenuItem});
            this.selectSearchEngineToolStripMenuItem.Name = "selectSearchEngineToolStripMenuItem";
            this.selectSearchEngineToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.selectSearchEngineToolStripMenuItem.Text = "Select Search Engine";
            this.selectSearchEngineToolStripMenuItem.Click += new System.EventHandler(this.selectSearchEngineToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // duckDuckGoToolStripMenuItem
            // 
            this.duckDuckGoToolStripMenuItem.Name = "duckDuckGoToolStripMenuItem";
            this.duckDuckGoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.duckDuckGoToolStripMenuItem.Text = "DuckDuckGo";
            this.duckDuckGoToolStripMenuItem.Click += new System.EventHandler(this.duckDuckGoToolStripMenuItem_Click);
            // 
            // bingToolStripMenuItem
            // 
            this.bingToolStripMenuItem.Name = "bingToolStripMenuItem";
            this.bingToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bingToolStripMenuItem.Text = "Bing";
            this.bingToolStripMenuItem.Click += new System.EventHandler(this.bingToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripMenuItem3});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "100%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(96, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Location = new System.Drawing.Point(907, 9);
            this.go.MaximumSize = new System.Drawing.Size(34, 23);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(34, 23);
            this.go.TabIndex = 2;
            this.go.Text = "⤨";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // webViewMain
            // 
            this.webViewMain.AllowExternalDrop = true;
            this.webViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webViewMain.CreationProperties = null;
            this.webViewMain.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.webViewMain.Location = new System.Drawing.Point(-3, 38);
            this.webViewMain.Name = "webViewMain";
            this.webViewMain.Size = new System.Drawing.Size(991, 726);
            this.webViewMain.TabIndex = 3;
            this.webViewMain.ZoomFactor = 1D;
            this.webViewMain.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webViewMain_CoreWebView2InitializationCompleted);
            this.webViewMain.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webViewMain_NavigationStarting);
            this.webViewMain.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webViewMain_NavigationCompleted);
            this.webViewMain.Click += new System.EventHandler(this.webViewMain_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 8);
            this.back.MaximumSize = new System.Drawing.Size(22, 23);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(22, 23);
            this.back.TabIndex = 4;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(40, 8);
            this.refresh.MaximumSize = new System.Drawing.Size(22, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(22, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "↻";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(68, 8);
            this.forward.MaximumSize = new System.Drawing.Size(22, 23);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(22, 23);
            this.forward.TabIndex = 6;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // Reload_Anim_label
            // 
            this.Reload_Anim_label.AutoSize = true;
            this.Reload_Anim_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reload_Anim_label.ForeColor = System.Drawing.Color.Coral;
            this.Reload_Anim_label.Location = new System.Drawing.Point(44, 13);
            this.Reload_Anim_label.MaximumSize = new System.Drawing.Size(22, 23);
            this.Reload_Anim_label.Name = "Reload_Anim_label";
            this.Reload_Anim_label.Size = new System.Drawing.Size(18, 15);
            this.Reload_Anim_label.TabIndex = 7;
            this.Reload_Anim_label.Text = "↻";
            // 
            // TheBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.Reload_Anim_label);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.back);
            this.Controls.Add(this.webViewMain);
            this.Controls.Add(this.go);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TheBrowser";
            this.Text = "JadeGo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button go;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMain;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Label Reload_Anim_label;
        private System.Windows.Forms.ToolStripMenuItem allowHttpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSearchEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duckDuckGoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

