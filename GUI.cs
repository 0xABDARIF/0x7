using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ICore;
using Protections;
using Protections.ControlFlow;
using Protections.Mutation;
using Optimization;
using Protections.Renaming;
using System.Linq;
using dnlib.DotNet;
using System.Collections;
using Microsoft.Win32;

namespace _0x7_Protector_GUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            ProtectionsPage.AutoScroll = true;
            ProtectionsPage.AutoScrollMargin = new Size(0, 20);
            ProtectionsPage.AutoScrollMinSize = new Size(0, 20);
            CheckAll_Button.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\CheckAll.png");
            Recommended.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\Recommend.png");
            Opacity = 0.98;
            //if (Q3X8VE.C53ETA.a == "1" == false || Q3X8VE.C53ETA.b == 1 == false || !Q3X8VE.C53ETA.c == true || !Q3X8VE.C53ETA.feb == true)
            //    Environment.Exit(0);
        }
        #region Control Box
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        #region Social
        private void DiscordServer_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/users/550441121822539834");
        }
        #endregion
        #region Logger
        DateTime begin;
        private void AppendToLog(string format, params object[] args) => LogText.AppendText(string.Format(format, args) + Environment.NewLine);
        private void AppendToLogF(string format, params object[] args) => LogText.AppendText(string.Format(format, args));
        public void Starting()
        {
            LogText.Clear();
            begin = DateTime.Now;
        }
        public void Finish()
        {
            DateTime now = DateTime.Now;
            string timeString = string.Format(
                "at {0}, {1}:{2:d2} elapsed.",
                now.ToShortTimeString(),
                (int)now.Subtract(begin).TotalMinutes,
                now.Subtract(begin).Seconds);
            AppendToLogF("[Info] Obfuscation Completed ! : " + timeString);
        }
        #endregion
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void iLabel6_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                if (TR_CBOX.Checked)
                {
                    Opacity = 0.96;
                    Cursor = Cursors.Hand;
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    Opacity = 0.98;
                    Cursor = Cursors.Default;
                }
                else
                {
                    Cursor = Cursors.Hand;
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    Cursor = Cursors.Default;
                }
            }
        }
        #endregion
        #region Pages
        private void BackToProtections_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ProtectionsPage);
        }
        private void GoToACS_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(AntiCrackSettings);
        }
        private void Reports_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(HelpPage);
        }
        private void Credits_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(CreditsPage);
        }
        private void Guide_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(GuidePage);
        }
        private void GoToMain_Click(object sender, EventArgs e)
        {
            GoToMain.FillColor = Color.FromArgb(229, 57, 53);
            GoToProtections.FillColor = Color.FromArgb(10, 10, 10);
            GoToRenamer.FillColor = Color.FromArgb(10, 10, 10);
            GoToVirtualization.FillColor = Color.FromArgb(10, 10, 10);
            GoToCodeOptimization.FillColor = Color.FromArgb(10, 10, 10);
            GoToLog.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(MainPage);
        }
        private void GoToProtections_Click(object sender, EventArgs e)
        {
            GoToProtections.FillColor = Color.FromArgb(229, 57, 53);
            GoToMain.FillColor = Color.FromArgb(10, 10, 10);
            GoToRenamer.FillColor = Color.FromArgb(10, 10, 10);
            GoToVirtualization.FillColor = Color.FromArgb(10, 10, 10);
            GoToCodeOptimization.FillColor = Color.FromArgb(10, 10, 10);
            GoToLog.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(ProtectionsPage);
            ProtectionsPage.AutoScrollPosition = new Point(-ProtectionsPage.AutoScrollPosition.Y, 0);
        }
        private void GoToRenamer_Click(object sender, EventArgs e)
        {
            GoToRenamer.FillColor = Color.FromArgb(229, 57, 53);
            GoToMain.FillColor = Color.FromArgb(10, 10, 10);
            GoToProtections.FillColor = Color.FromArgb(10, 10, 10);
            GoToVirtualization.FillColor = Color.FromArgb(10, 10, 10);
            GoToCodeOptimization.FillColor = Color.FromArgb(10, 10, 10);
            GoToLog.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(RenamerPage);
        }
        private void GoToVirtualization_Click(object sender, EventArgs e)
        {
            GoToVirtualization.FillColor = Color.FromArgb(229, 57, 53);
            GoToMain.FillColor = Color.FromArgb(10, 10, 10);
            GoToProtections.FillColor = Color.FromArgb(10, 10, 10);
            GoToRenamer.FillColor = Color.FromArgb(10, 10, 10);
            GoToCodeOptimization.FillColor = Color.FromArgb(10, 10, 10);
            GoToLog.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(VirtualizationPage);
        }
        private void GoToCodeOptimization_Click(object sender, EventArgs e)
        {
            GoToCodeOptimization.FillColor = Color.FromArgb(229, 57, 53);
            GoToMain.FillColor = Color.FromArgb(10, 10, 10);
            GoToProtections.FillColor = Color.FromArgb(10, 10, 10);
            GoToRenamer.FillColor = Color.FromArgb(10, 10, 10);
            GoToVirtualization.FillColor = Color.FromArgb(10, 10, 10);
            GoToLog.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(CodeOptimizationPage);
        }
        private void GoToLog_Click(object sender, EventArgs e)
        {
            GoToLog.FillColor = Color.FromArgb(229, 57, 53);
            GoToMain.FillColor = Color.FromArgb(10, 10, 10);
            GoToProtections.FillColor = Color.FromArgb(10, 10, 10);
            GoToRenamer.FillColor = Color.FromArgb(10, 10, 10);
            GoToVirtualization.FillColor = Color.FromArgb(10, 10, 10);
            GoToCodeOptimization.FillColor = Color.FromArgb(10, 10, 10);
            TabControl1.SelectTab(LogPage);
        }
        #endregion
        #region Import Assembly
        public static Context ctx;
        private void AddAssembly_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog x = new System.Windows.Forms.OpenFileDialog();
            x.Title = "Load Assembly";
            x.Filter = ".NET Assembly (*.exe)|*.exe|(*.dll)|*.dll";
            x.Multiselect = false;
            if (x.ShowDialog() == DialogResult.OK)
            {
                AsmPath.Text = x.FileName;
                string text = AsmPath.Text;
                int num = text.LastIndexOf(".");
                if (num != -1)
                {
                    string text2 = text.Substring(num);
                    text2 = text2.ToLower();
                    if (text2 == ".exe" || text2 == ".dll")
                    {
                        AsmPath.Text = text;
                        SavePath.Text = Path.Combine(Path.GetDirectoryName(AsmPath.Text) + @"\Protected");
                        ctx = new Context(AsmPath.Text);
                        Import();
                    }
                }
            }
        }
        private void AsmPath_DragDrop(object sender, DragEventArgs e)
        {
            Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
            if (array != null)
            {
                string text = array.GetValue(0).ToString();
                int num = text.LastIndexOf(".");
                int num2 = text.LastIndexOf("\\");
                if (num != -1)
                {
                    string text2 = text.Substring(num);
                    text2 = text2.ToLower();
                    if (text2 == ".exe" || text2 == ".dll")
                    {
                        AsmPath.Text = text;
                        SavePath.Text = Path.Combine(Path.GetDirectoryName(AsmPath.Text) + @"\Protected");
                        ctx = new Context(AsmPath.Text);
                        Import();
                    }
                }
            }
        }
        private void AsmPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog x = new FolderBrowserDialog();
            x.Description = "Select folder";
            if (x.ShowDialog() == DialogResult.OK)
            {
                SavePath.Text = x.SelectedPath;
            }
        }
        #endregion
        #region Control Flow Settings
        private void ControlFlowSelection_ValueChanged(object sender, EventArgs e)
        {
            switch (ControlFlowSelection.Value)
            {
                case 0:
                    ControlFlowStatus.Text = "Off";
                    break;
                case 1:
                    ControlFlowStatus.Text = "Strong";
                    // Virt_cbox.Checked = false;
                    break;
                case 2:
                    ControlFlowStatus.Text = "Aggressive";
                    // Virt_cbox.Checked = false;
                    break;             
            }
        }
        public void ExecuteCflow(Context context)
        {
            switch (ControlFlowSelection.Value)
            {
                case 0:
                    break;
                case 1:
                    Protections.StrongControlFlow.ControlFlow.Execute(context);
                    break;
                case 2:
                    ControlFlow.Execute(context);
                    break;               
            }
        }
        #endregion
        #region Strings Settings
        private void GoToStrings_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(StringsSettingsPage);
        }
        private void siticoneImageButton4_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ProtectionsPage);
        }
        public void ExecuteStrings(Context context)
        {
            if (CEStr_CBOX.Checked)
                StringEncryption2.Execute(context);
            if (Xor_CBOX.Checked)
                new Protections.Xor.StringEncryption().Run(context);
            if (Str2FE_CBOX.Checked)
                StringEncryption.Execute(context);
        }
        #endregion
        #region Protect Assembly
        public static string browseDir;
        public static string browseDir2;
        public static string FPath;
        public static string FPath2;
        public static bool Virt;
        private void ProtectAssembly_Click(object sender, EventArgs e)
        {
            try
            {
                Starting();
                GoToLog.PerformClick();
                //Load
                if (AsmPath.Text.EndsWith(".dll".ToLower()))
                {
                    AppendToLog("[ ! ] Warning : you are trying to obfuscate .dll file !, so these protections will be disabled .");
                    AppendToLog("Flood Cctor, Anti Dump, Anti Virtual Machine, Anti Crack, Anti Http Debug & Anti Debug");
                    AppendToLog("");
                    AntiDump_cbox.Checked = false;
                    AntiVM_cbox.Checked = false;
                    AntiCracker_cbox.Checked = false;
                    AntiHttp_cbox.Checked = false;
                    AntiDebug_cbox.Checked = false;
                }
                ctx = new Context(AsmPath.Text);
                ctx.FileName = Path.GetFileName(AsmPath.Text);
                ctx.DirPath = SavePath.Text;
                browseDir = ctx.DirPath;
                browseDir2 = Path.GetDirectoryName(AsmPath.Text);
                ctx.OutPutPath = SavePath.Text + @"\" + ctx.FileName;
                //Obfuscation
                AppendToLog("Obfuscating ....");
                if (HideEP_cbox.Checked)
                {
                    MoveEntryPoint.Execute(ctx);
                    AppendToLog("Executed : Hide Entrypoint");
                }
                if (Renaming_cbox.Checked)
                {
                    if (SaveNameMap_CBOX.Checked)
                    {
                        SaveNMap.Extract(ctx);
                        AppendToLog("[Info] Name map exported, check desktop !");
                    }
                    if (rFields_cbox.Checked)
                        proprenamer = true;
                    if (rProperties_cbox.Checked)
                        fieldrenamer = true;
                    Renamer.Execute(ctx, proprenamer, fieldrenamer);
                    if (SaveNameMap_CBOX.Checked)
                    {
                        SaveNMap.ExportObfuscatedNames(ctx);
                    }
                    AppendToLog("Executed : Renaming Obfuscation");
                }
                if (Junk_cbox.Checked)
                {
                    if (JunkClasses_CBOX.Checked)
                    {
                        Junk.Execute(ctx, Convert.ToInt32(JunkLength.Text));
                        AppendToLog("Executed : Junk Classes Adder");
                    }
                    if (JunkMethods_CBOX.Checked)
                    {
                        JAdder.Add(ctx, Convert.ToInt32(JunkMLength.Text), JunkCName.Text, JunkContent.Text);
                        AppendToLog("Executed : Junk Methods Adder");
                    }
                }
                if (MathInts_cbox.Checked)
                {
                    IntMathProtection.Execute(ctx);
                    //NumberObfuscation.Execute(ctx);
                    AppendToLog("Executed : Math Ints");
                }
                if (Controlflow_CBOX.Checked)
                {
                    if (ControlFlowSelection.Value == 0 == false)
                    {
                        ExecuteCflow(ctx);
                        AppendToLog("Executed : Control Flow");
                    }
                }
                if (L2F_cbox.Checked)
                {
                    LocalToField.Execute1(ctx);
                    AppendToLog("Executed : Local To Field");
                }
                if (RProxy_CBOX.Checked)
                {
                    if (BasicRef_CBOX.Checked)
                    {
                        BasicReferenceProxy.Execute(ctx);
                        AppendToLog("Executed : Basic Reference Proxy");
                    }
                    if (StrongRef_CBOX.Checked)
                    {
                        FixedReferenceProxy.Execute(ctx);
                        AppendToLog("Executed : Strong Reference Proxy");
                    }
                }
                if (ConstantsMelting_CBOX.Checked)
                {
                    ExecuteMelt(ctx);
                    AppendToLog("Executed : Constants Melting");
                }             
                if (Mutation_CBOX.Checked)
                {
                    MutationConfusion.Execute(ctx);
                    AppendToLog("Executed : Mutation");
                }
                if (AntiCracker_cbox.Checked)
                {
                    if (BanCracker_CBOX.Checked)
                        global.Status = "1";
                    if (!BanCracker_CBOX.Checked)
                        global.Status = "0";
                    if (siticoneOSToggleSwith1.Checked)
                        global.SIMG = "1";
                    if (!siticoneOSToggleSwith1.Checked)
                        global.SIMG = "0";
                    global.rnd = Path.GetTempPath() + ICore.Utils.GenerateString() + ".jpg";
                    if (SendToWH_cbox.Checked)
                    {
                        DetectCrackersYHook.Inject(ctx);
                        AppendToLog("Executed : Anti Cracking ( Data Sender )");
                    }
                    else
                    {
                        DetectCrackersNHook.Inject(ctx);
                        AppendToLog("Executed :  Anti Cracking");
                    }
                }
                if (AntiHttp_cbox.Checked)
                {
                    InjectAntiHttp.Inject(ctx);
                    AppendToLog("Executed : Anti Http Debugging");
                }
                if (AntiVM_cbox.Checked)
                {
                    InjectAntiVM.Inject(ctx);
                    InjectAntiVM.Inject2(ctx);
                    AppendToLog("Executed : Anti Virtual Machine");
                }
                if (AntiDump_cbox.Checked)
                {
                    //NewAntiDump.Execute(ctx);
                    AntiDump.Execute(ctx);
                    AppendToLog("Executed : Anti Dump");
                }
                if (AntiDebug_cbox.Checked)
                {
                    AntiDebug.Execute(ctx);
                    AppendToLog("Executed : Anti Debug");
                }
                if (CallV_CBOX.Checked)
                {
                    new CallConvertion(ctx);
                    AppendToLog("Executed : Call Convertion");
                }
                
                if (Strings_CBOX.Checked)
                {
                    if (CEStr_CBOX.Checked || Xor_CBOX.Checked || Str2FE_CBOX.Checked)
                    {
                        ExecuteStrings(ctx);
                        AppendToLog("Executed : Strings Encoding");
                    }
                }            
                if (HideMethods_cbox.Checked)
                {
                    new ExAntiTamper.AntiTamperNormal().AntiTamper(ctx);
                    AppendToLog("Executed : Encrypt Methods");
                }
                if (HideMethods_cbox.Checked)
                {
                    HideMethods.Execute(ctx);
                }
                if (FakeObf_cbox.Checked)
                {
                    FakeAttributes.Execute(ctx);
                    AppendToLog("Executed : Fake Obfuscation");
                }
                //Optimization
                if (OptimizeMethods_cbox.Checked)
                {
                    MethodsOptimization.Optimize(ctx);
                    AppendToLog("Optimized Methods");
                }
                if (OptimizeCode_cbox.Checked)
                {
                    OptimizeCode.Optimize(ctx);
                    AppendToLog("Optimized Codes");
                }
                if (ReduceMD_cbox.Checked)
                {
                    ReduceMetadata.Execute(ctx);
                    AppendToLog("Reduced Meta Data");
                }
                //Save
                ctx.SaveFile();
                FPath2 = ctx.OutPutPath;
                //
                if (Virt_cbox.Checked)
                {
                    AppendToLog("Virtualizing ....");
                    Virt = true;
                    FPath = ctx.OutPutPath;
                    string sReplacer = ctx.OutPutPath.Replace(".exe", "-VM.exe"); ;
                    byte[] assemblyProtected = Core.Protector.Protect(File.ReadAllBytes(FPath));
                    File.WriteAllBytes(sReplacer, assemblyProtected);
                    AppendToLog("Virtualized Methods !");
                }
                //
                ctx.Clear();
                //
                if (SaveProtections_CBOX.Checked)
                {
                    StreamWriter streamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Saved.txt");
                    streamWriter.WriteLine("Saved protection:\n———————————");
                    //
                    if (HideEP_cbox.Checked)
                        streamWriter.WriteLine("Hide EP = true");
                    if (FakeObf_cbox.Checked)
                        streamWriter.WriteLine("Fake Obfuscation = true");
                    if (CallV_CBOX.Checked)
                        streamWriter.WriteLine("Call Convertion = true");
                    if (BasicRef_CBOX.Checked)
                        streamWriter.WriteLine("Basic RProxy = true");
                    if (StrongRef_CBOX.Checked)
                        streamWriter.WriteLine("Strong RProxy = true");
                    //
                    if (Junk_cbox.Checked)
                        streamWriter.WriteLine("Junk = true");
                    if (JunkClasses_CBOX.Checked)
                        streamWriter.WriteLine("Junk Classes = true");
                    if (JunkMethods_CBOX.Checked)
                        streamWriter.WriteLine("Junk Methods = true");
                    //
                    if (CEStr_CBOX.Checked)
                        streamWriter.WriteLine("CEncode Strings = true");
                    if (Xor_CBOX.Checked)
                        streamWriter.WriteLine("Xor Strings = true");
                    if (Str2FE_CBOX.Checked)
                        streamWriter.WriteLine("Strings 2 Fields = true");
                    //
                    if (ConstantsMelting_CBOX.Checked)
                        streamWriter.WriteLine("Melter = true");
                    if (MeltInt_CBOX.Checked)
                        streamWriter.WriteLine("Melt Integers = true");
                    if (MeltStr_CBOX.Checked)
                        streamWriter.WriteLine("Melt Strings = true");
                    //
                    if (SendToWH_cbox.Checked)
                        streamWriter.WriteLine("Send Data = true");
                    if (BanCracker_CBOX.Checked)
                        streamWriter.WriteLine("Ban Cracker = true");
                    if (siticoneOSToggleSwith1.Checked)
                        streamWriter.WriteLine("Capture Screen = true");
                    //
                    if (rProperties_cbox.Checked)
                        streamWriter.WriteLine("Properties = true");
                    if (rFields_cbox.Checked)
                        streamWriter.WriteLine("Fields = true");
                    //
                    streamWriter.WriteLine("Types = true");
                    if (HideMethods_cbox.Checked)
                        streamWriter.WriteLine("Anti tamper = true");
                    if (AntiDump_cbox.Checked)
                        streamWriter.WriteLine("Anti dump = true");
                    if (AntiVM_cbox.Checked)
                        streamWriter.WriteLine("Anti vm = true");
                    if (AntiCracker_cbox.Checked)
                        streamWriter.WriteLine("Anti crack = true");
                    if (AntiHttp_cbox.Checked)
                        streamWriter.WriteLine("Anti http = true");
                    if (AntiDebug_cbox.Checked)
                        streamWriter.WriteLine("Anti debug = true");                  
                    if (Strings_CBOX.Checked)
                        streamWriter.WriteLine("Strings encoding = true");
                    if (MathInts_cbox.Checked)
                        streamWriter.WriteLine("Int math = true");
                    if (Mutation_CBOX.Checked)
                        streamWriter.WriteLine("Mutation = true");
                    if (OutlineStrings_CBOX.Checked)
                        streamWriter.WriteLine("Outliner = true");
                    if (RProxy_CBOX.Checked)
                        streamWriter.WriteLine("Ref proxy = true");
                    //
                    if (Controlflow_CBOX.Checked)
                        streamWriter.WriteLine("Control flow = true");
                    if (ControlFlowSelection.Value == 1)
                        streamWriter.WriteLine("Control Flow Preset 1 = true");
                    if (ControlFlowSelection.Value == 2)
                        streamWriter.WriteLine("Control Flow Preset 2 = true");
                    if (ControlFlowSelection.Value == 3)
                        streamWriter.WriteLine("Control Flow Preset 3 = true");
                    if (ControlFlowSelection.Value == 4)
                        streamWriter.WriteLine("Control Flow Preset 4 = true");
                    if (ControlFlowSelection.Value == 5)
                        streamWriter.WriteLine("Control Flow Preset 5 = true");
                    if (ControlFlowSelection.Value == 6)
                        streamWriter.WriteLine("Control Flow Preset 6 = true");
                    //
                    if (L2F_cbox.Checked)
                        streamWriter.WriteLine("L2F = true");
                    if (Renaming_cbox.Checked)
                        streamWriter.WriteLine("Renamer = true");
                    streamWriter.Dispose();
                }
                //
                Activate();
                Finish();
                Form form = new Finished();
                form.ShowDialog();
            }
            catch (Exception ex) { AppendToLog(ex.ToString()); }
        }
        #endregion
        #region Check All
        bool CAll = false;
        private void CheckAll_Button_Click_1(object sender, EventArgs e)
        {
            if (!CAll)
            {
                CAll = true;
                CheckAll_Button.Text = "Uncheck All";
                HideEP_cbox.Checked = true;
                FakeObf_cbox.Checked = true;
                CallV_CBOX.Checked = true;
                Strings_CBOX.Checked = true;
                Controlflow_CBOX.Checked = true;
                Mutation_CBOX.Checked = true;
                AntiCracker_cbox.Checked = true;
                AntiHttp_cbox.Checked = true;
                AntiVM_cbox.Checked = true;
                AntiDebug_cbox.Checked = true;
                AntiDump_cbox.Checked = true;
                HideMethods_cbox.Checked = true;
                Xor_CBOX.Checked = true;
                CEStr_CBOX.Checked = true;
                Str2FE_CBOX.Checked = true;
                L2F_cbox.Checked = true;
                Renaming_cbox.Checked = true;
                Junk_cbox.Checked = true;
                JunkClasses_CBOX.Checked = true;
                JunkMethods_CBOX.Checked = true;
                MathInts_cbox.Checked = true;
                ControlFlowSelection.Value = 2;
                RProxy_CBOX.Checked = true;
                ConstantsMelting_CBOX.Checked = true;
                MeltInt_CBOX.Checked = true;
                MeltStr_CBOX.Checked = true;
                BasicRef_CBOX.Checked = true;
                StrongRef_CBOX.Checked = true;
                CheckAll_Button.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\UncheckAll.png");
            }
            else
            {
                CAll = false;
                CheckAll_Button.Text = "Check All";
                HideEP_cbox.Checked = false;
                FakeObf_cbox.Checked = false;
                CallV_CBOX.Checked = false;
                Strings_CBOX.Checked = false;
                Controlflow_CBOX.Checked = false;
                Mutation_CBOX.Checked = false;
                HideMethods_cbox.Checked = false;
                AntiCracker_cbox.Checked = false;
                AntiHttp_cbox.Checked = false;
                AntiVM_cbox.Checked = false;
                AntiDebug_cbox.Checked = false;
                AntiDump_cbox.Checked = false;
                Xor_CBOX.Checked = false;
                CEStr_CBOX.Checked = false;
                Str2FE_CBOX.Checked = false;
                L2F_cbox.Checked = false;
                Renaming_cbox.Checked = false;
                Junk_cbox.Checked = false;
                MathInts_cbox.Checked = false;
                ControlFlowSelection.Value = 0;
                RProxy_CBOX.Checked = false;
                ConstantsMelting_CBOX.Checked = false;
                MeltInt_CBOX.Checked = false;
                MeltStr_CBOX.Checked = false;
                BasicRef_CBOX.Checked = false;
                StrongRef_CBOX.Checked = false;
                CheckAll_Button.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\CheckAll.png");
            }
        }
        #endregion
        #region Protections Settings
        private void StrongRef_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (StrongRef_CBOX.Checked)
            {
                VMAll.Checked = false;
            }
        }
        private void HideMethods_cbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (HideMethods_cbox.Checked)
            {
                ExAntiTamper.ATGlobal.atamper = true;
                Virt_cbox.Checked = false;
                AntiDump_cbox.Checked = false;
            }
            else
            {
                ExAntiTamper.ATGlobal.atamper = false;
            }
        }
        private void AntiDump_cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiDump_cbox.Checked)
            {
                HideMethods_cbox.Checked = false;
            }
        }
        private void Virt_cbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Virt_cbox.Checked)
            {
                JunkMethods_CBOX.Checked = false;
                HideMethods_cbox.Checked = false;
                CallV_CBOX.Checked = false;
                ConstantsMelting_CBOX.Checked = false;
            }
        }
        private void CallV_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (CallV_CBOX.Checked)
            {
                Virt_cbox.Checked = false;
            }
        }
        private void ConstantsMelting_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (ConstantsMelting_CBOX.Checked)
            {
                Virt_cbox.Checked = false;
            }
        }
        #endregion
        #region Anti Crack Settings
        private void SendToWH_cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SendToWH_cbox.Checked)
            {
                LinkStatus.Visible = true;
            }
            else
            {
                LinkStatus.Text = "";
                LinkStatus.Visible = false;
            }
        }
        private void PasteWHLink_Click(object sender, EventArgs e)
        {
            global.ID = GetText();
            LinkStatus.Text = "Pasted !";
        }
        public static string GetText()
        {
            if (Clipboard.ContainsText())
            {
                return Clipboard.GetText();
            }
            return string.Empty;
        }
        private void UnBanBtn_Click(object sender, EventArgs e)
        {
            string keyPath64Bit = "SOFTWARE\\0x7";
            RegistryKey cu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            RegistryKey key64Bit = cu.OpenSubKey(keyPath64Bit, true);
            iLabel63.Text = "You are not banned !";
            if (key64Bit != null)
            {
                var namesArray = key64Bit.GetValueNames();
                foreach (string valueName in namesArray)
                {
                    key64Bit.DeleteValue(valueName);
                    iLabel63.Text = "Unbanned !";
                }
            }
            string keyPath32Bit = "SOFTWARE\\0x7";
            RegistryKey cuu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
            RegistryKey key32Bit = cu.OpenSubKey(keyPath32Bit, true);
            iLabel63.Text = "You are not banned !";
            if (key32Bit != null)
            {
                var namesArray = key32Bit.GetValueNames();
                foreach (string valueName in namesArray)
                {
                    key32Bit.DeleteValue(valueName);
                    iLabel63.Text = "Unbanned !";
                }
            }
        }
        #endregion
        #region Junk Settings  
        private void JunkSettings_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(JunkSettingsPage);
        }
        private void siticoneImageButton5_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ProtectionsPage);
        }
        private void JunkLength_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void JunkMLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Melt Settings
        public void ExecuteMelt(Context ctx)
        {
            if (MeltStr_CBOX.Checked)
            {
                ConstantMelting.MeltStrings(ctx);
            }
            if (MeltInt_CBOX.Checked)
            {
                ConstantMelting.MeltIntegers(ctx);
            }
        }
        private void siticoneImageButton3_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ProtectionsPage);
        }
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ConstansMeltingPage);
        }
        #endregion
        #region RefP Settings
        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(RefProxyPage);
        }
        private void siticoneImageButton6_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(ProtectionsPage);
        }
        #endregion
        #region Recommended
        private void Recommended_Click(object sender, EventArgs e)
        {
            HideEP_cbox.Checked = true;
            AntiDump_cbox.Checked = false;
            AntiVM_cbox.Checked = false;
            AntiHttp_cbox.Checked = false;
            Junk_cbox.Checked = false;
            HideMethods_cbox.Checked = true;
            AntiDebug_cbox.Checked = true;
            Strings_CBOX.Checked = true;
            Xor_CBOX.Checked = true;
            MathInts_cbox.Checked = true;
            Mutation_CBOX.Checked = true;
            Controlflow_CBOX.Checked = true;
            ControlFlowSelection.Value = 1;
            L2F_cbox.Checked = true;
            FakeObf_cbox.Checked = true;
            Renaming_cbox.Checked = true;
            rProperties_cbox.Checked = false;
            rFields_cbox.Checked = false;
        }
        #endregion
        #region VM Settings    
        private void SaveSame_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveSame_CBOX.Checked)
            {
                SavePath.Enabled = false;
                Context.samePath = true;
            }
            else
            {
                SavePath.Enabled = true;
                Context.samePath = false;
            }
        }
        private void treeView1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.BackColor = Color.FromArgb(10, 10, 10);
        }
        private bool SearchRecursive(IEnumerable nodes, string searchFor)
        {        
            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(searchFor))
                {
                    treeView1.SelectedNode = node;
                    node.BackColor = Color.Gray;
                }
                if (SearchRecursive(node.Nodes, searchFor))
                    return true;
            }
            return false;
        }
        private void SearchForMethod_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.BackColor = Color.FromArgb(10, 10, 10);
            var searchFor = SMethodText.Text.Trim().ToUpper();
            if (searchFor != "")
            {
                if (treeView1.Nodes.Count > 0)
                {
                    if (SearchRecursive(treeView1.Nodes, searchFor))
                    {
                        treeView1.SelectedNode.Expand();
                        treeView1.Focus();
                    }
                }
            }
        }
        private void VMAll_CheckedChanged(object sender, EventArgs e)
        {
            if (VMAll.Checked)
            {
                StrongRef_CBOX.Checked = false;
                VMUtils.Utils.ProtectAll = true;
                treeView1.Enabled = false;
            }
            else
            {
                VMUtils.Utils.ProtectAll = false;
                treeView1.Enabled = true;
            }
        }
        private void Import()
        {
            this.treeView1.Nodes.Clear();
            foreach (TypeDef typeDef in ctx.Module.GetTypes())
            {
                VMUtils.Utils.hashSet.Add(typeDef.Namespace);
            }
            VMUtils.Utils.hashSet.Distinct<string>();
            foreach (TypeDef typeDef2 in ctx.Module.Types)
            {
                TreeNode treeNode = new TreeNode(typeDef2.Name, 0, 0);
                treeNode.Tag = 1;
                foreach (MethodDef methodDef in typeDef2.Methods)
                {
                    if (methodDef != ctx.Module.GlobalType.FindOrCreateStaticConstructor())
                    {
                        TreeNode treeNode2 = new TreeNode(methodDef.FullName + " MDToken : " + methodDef.MDToken.ToString());
                        if (methodDef.IsPublic && methodDef.IsConstructor)
                        {

                            treeNode2.ImageIndex = 2;
                            treeNode2.SelectedImageIndex = 2;
                        }
                        else if (methodDef.IsPrivate && methodDef.IsConstructor)
                        {
                            treeNode2.ImageIndex = 3;
                            treeNode2.SelectedImageIndex = 3;
                        }
                        else if (methodDef.IsAssembly && methodDef.IsConstructor)
                        {
                            treeNode2.ImageIndex = 4;
                            treeNode2.SelectedImageIndex = 4;
                        }
                        else if (methodDef.IsFamily && methodDef.IsConstructor)
                        {
                            treeNode2.ImageIndex = 5;
                            treeNode2.SelectedImageIndex = 5;
                        }
                        else if (methodDef.IsFamilyOrAssembly && methodDef.IsConstructor)
                        {
                            treeNode2.ImageIndex = 6;
                            treeNode2.SelectedImageIndex = 6;
                        }
                        else if (methodDef.IsPublic)
                        {
                            treeNode2.ImageIndex = 2;
                            treeNode2.SelectedImageIndex = 2;
                        }
                        else if (methodDef.IsPrivate)
                        {
                            treeNode2.ImageIndex = 3;
                            treeNode2.SelectedImageIndex = 3;
                        }
                        else if (methodDef.IsAssembly)
                        {
                            treeNode2.ImageIndex = 4;
                            treeNode2.SelectedImageIndex = 4;
                        }
                        else if (methodDef.IsFamily)
                        {
                            treeNode2.ImageIndex = 5;
                            treeNode2.SelectedImageIndex = 5;
                        }
                        else if (methodDef.IsFamilyOrAssembly)
                        {
                            treeNode2.ImageIndex = 6;
                            treeNode2.SelectedImageIndex = 6;
                        }
                        treeNode2.Tag = 2;
                        treeNode.Nodes.Add(treeNode2);
                        VMUtils.Utils.tempMethodsList.Add(methodDef.FullName);
                    }
                }
                this.treeView1.Nodes.Add(treeNode);
            }
            TreeNode treeNode3 = null;
            foreach (string text in VMUtils.Utils.hashSet)
            {
                if (text != string.Empty)
                {
                    treeNode3 = new TreeNode(text, 0, 0);
                    treeNode3.Tag = 0;
                    this.treeView1.Nodes.Add(treeNode3);
                    foreach (TypeDef typeDef3 in ctx.Module.Types)
                    {
                        if (treeNode3.Text == typeDef3.Namespace && typeDef3.Namespace != string.Empty && !typeDef3.IsValueType && !typeDef3.IsInterface)
                        {
                            string text2 = (typeDef3.Name.Contains("`") ? typeDef3.Name.Substring(0, typeDef3.Name.IndexOf('`')) : typeDef3.Name.Replace("`", string.Empty));
                            TreeNode treeNode4 = new TreeNode(text2, 0, 0);
                            treeNode4.Tag = 1;
                            foreach (MethodDef methodDef2 in typeDef3.Methods)
                            {
                                if (methodDef2 != ctx.Module.GlobalType.FindOrCreateStaticConstructor())
                                {
                                    TreeNode treeNode5 = new TreeNode(methodDef2.FullName);
                                    if (methodDef2.IsPublic && methodDef2.IsConstructor)
                                    {
                                        treeNode5.ImageIndex = 2;
                                        treeNode5.SelectedImageIndex = 2;
                                    }
                                    else if (methodDef2.IsPrivate && methodDef2.IsConstructor)
                                    {
                                        treeNode5.ImageIndex = 3;
                                        treeNode5.SelectedImageIndex = 3;
                                    }
                                    else if (methodDef2.IsAssembly && methodDef2.IsConstructor)
                                    {
                                        treeNode5.ImageIndex = 4;
                                        treeNode5.SelectedImageIndex = 4;
                                    }
                                    else if (methodDef2.IsFamily && methodDef2.IsConstructor)
                                    {
                                        treeNode5.ImageIndex = 5;
                                        treeNode5.SelectedImageIndex = 5;
                                    }
                                    else if (methodDef2.IsFamilyOrAssembly && methodDef2.IsConstructor)
                                    {
                                        treeNode5.ImageIndex = 6;
                                        treeNode5.SelectedImageIndex = 6;
                                    }
                                    else if (methodDef2.IsPublic)
                                    {
                                        treeNode5.ImageIndex = 2;
                                        treeNode5.SelectedImageIndex = 2;
                                    }
                                    else if (methodDef2.IsPrivate)
                                    {
                                        treeNode5.ImageIndex = 3;
                                        treeNode5.SelectedImageIndex = 3;
                                    }
                                    else if (methodDef2.IsAssembly)
                                    {
                                        treeNode5.ImageIndex = 4;
                                        treeNode5.SelectedImageIndex = 4;
                                    }
                                    else if (methodDef2.IsFamily)
                                    {
                                        treeNode5.ImageIndex = 5;
                                        treeNode5.SelectedImageIndex = 5;
                                    }
                                    else if (methodDef2.IsFamilyOrAssembly)
                                    {
                                        treeNode5.ImageIndex = 6;
                                        treeNode5.SelectedImageIndex = 6;
                                    }
                                    treeNode5.Tag = 2;
                                    //treeNode4.Nodes.Add(treeNode5);
                                    VMUtils.Utils.tempMethodsList.Add(methodDef2.FullName);
                                }
                            }
                            treeNode3.Nodes.Add(treeNode4);
                        }
                    }
                }
            }
            try
            {
                int i = 0;
                while (i < this.treeView1.Nodes.Count)
                {
                    TreeNode treeNode6 = this.treeView1.Nodes[i];
                    if (treeNode6.Nodes.Count == 0)
                    {
                        this.treeView1.Nodes.Remove(treeNode6);
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            catch
            {
            }
            this.treeView1.Sort();
        }
        public static int test = 0;
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.ForeColor == Color.FromArgb(229, 57, 53))
            {
                treeView1.SelectedNode.ForeColor = Color.White;
                VMUtils.Utils.SelectedMethods = VMUtils.Utils.SelectedMethods.Replace(treeView1.SelectedNode.Text, "");
            }
            else
            {
                if (test == 1)
                {
                    test = 0;
                    treeView1.SelectedNode.ForeColor = Color.FromArgb(229, 57, 53);
                    string meth = treeView1.SelectedNode.Text.ToString();
                    VMUtils.Utils.SelectedMethods = VMUtils.Utils.SelectedMethods + meth;
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            test = 1;
        }
        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            if (e.KeyChar == (char)Keys.Enter && tn == null == false)
            {
                if (treeView1.SelectedNode.ForeColor == Color.FromArgb(229, 57, 53))
                {
                    treeView1.SelectedNode.ForeColor = Color.White;
                    VMUtils.Utils.SelectedMethods = VMUtils.Utils.SelectedMethods.Replace(treeView1.SelectedNode.Text, "");
                }
                else
                {
                    if (test == 1)
                    {
                        test = 0;
                        treeView1.SelectedNode.ForeColor = Color.FromArgb(229, 57, 53);
                        string meth = treeView1.SelectedNode.Text.ToString();
                        VMUtils.Utils.SelectedMethods = VMUtils.Utils.SelectedMethods + meth;
                    }
                }
            }
        }
        #endregion
        #region Renamer bools
        public static bool proprenamer { get; set; }
        public static bool fieldrenamer { get; set; }
        #endregion
        #region Donation
        private void DonateME_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(DonatePage);
        }
        private void Paypal_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/paypalme/inx707");
        }
        private void Bitcoin_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/raw/3tsH1PVL");
        }
        #endregion
        #region Saves
        private void ImportSession_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Saved.txt"))
            {
                string lines = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Saved.txt");
                if (lines.Contains("Hide EP = true"))
                    HideEP_cbox.Checked = true;
                if (lines.Contains("Fake Obfuscation = true"))
                    FakeObf_cbox.Checked = true;
                if (lines.Contains("Control Flow Preset 1 = true"))
                    ControlFlowSelection.Value = 1;
                if (lines.Contains("Control Flow Preset 2 = true"))
                    ControlFlowSelection.Value = 2;
                //
                if (lines.Contains("Basic RProxy = true"))
                    BasicRef_CBOX.Checked = true;
                if (lines.Contains("Strong RProxy = true"))
                    StrongRef_CBOX.Checked = true;
                //
                if (lines.Contains("Junk Classes = true"))
                    JunkClasses_CBOX.Checked = true;
                if (lines.Contains("Junk Methods = true"))
                    JunkMethods_CBOX.Checked = true;
                //
                if (lines.Contains("CEncode Strings = true"))
                    CEStr_CBOX.Checked = true;
                if (lines.Contains("Xor Strings = true"))
                    Xor_CBOX.Checked = true;
                if (lines.Contains("Strings 2 Fields = true"))
                    Str2FE_CBOX.Checked = true;
                //
                if (lines.Contains("Melter = true"))
                    ConstantsMelting_CBOX.Checked = true;
                if (lines.Contains("Melt Integers = true"))
                    MeltInt_CBOX.Checked = true;
                if (lines.Contains("Melt Strings = true"))
                    MeltStr_CBOX.Checked = true;
                //
                if (lines.Contains("Send Data = true"))
                    SendToWH_cbox.Checked = true;
                if (lines.Contains("Ban Cracker = true"))
                    BanCracker_CBOX.Checked = true;
                if (lines.Contains("Capture Screen = true"))
                    siticoneOSToggleSwith1.Checked = true;
                //
                if (lines.Contains("Properties = true"))
                    rProperties_cbox.Checked = true;
                if (lines.Contains("Fields = true"))
                    rFields_cbox.Checked = true;
                //
                if (lines.Contains("Call Convertion = true"))
                    CallV_CBOX.Checked = true;
                if (lines.Contains("Anti tamper = true"))
                    HideMethods_cbox.Checked = true;
                if (lines.Contains("Anti tamper = true"))
                    HideMethods_cbox.Checked = true;
                if (lines.Contains("Anti dump = true"))
                    AntiDump_cbox.Checked = true;
                if (lines.Contains("Anti vm = true"))
                    AntiVM_cbox.Checked = true;
                if (lines.Contains("Anti crack = true"))
                    AntiCracker_cbox.Checked = true;
                if (lines.Contains("Anti http = true"))
                    AntiHttp_cbox.Checked = true;
                if (lines.Contains("Anti debug = true"))
                    AntiDebug_cbox.Checked = true;
                if (lines.Contains("Junk = true"))
                    Junk_cbox.Checked = true;
                if (lines.Contains("Strings encoding = true"))
                    Strings_CBOX.Checked = true;
                if (lines.Contains("Int math = true"))
                    MathInts_cbox.Checked = true;
                if (lines.Contains("Mutation = true"))
                    Mutation_CBOX.Checked = true;
                if (lines.Contains("Ref proxy = true"))
                    RProxy_CBOX.Checked = true;
                if (lines.Contains("Control flow = true"))
                    Controlflow_CBOX.Checked = true;
                if (lines.Contains("L2F = true"))
                    L2F_cbox.Checked = true;
                if (lines.Contains("Renamer = true"))
                    Renaming_cbox.Checked = true;
            }
        }
        #endregion
        #region GUI Settings
        private void GoToSettings_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(SettingsPage);
        }
        private void TR_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (TR_CBOX.Checked)
            {
                Opacity = 0.98;
            }
            else
            {
                Opacity = 100;
            }
        }
        private void AOT_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (AOT_CBOX.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
        private void FlatB_CBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (FlatB_CBOX.Checked)
                siticoneElipse1.BorderRadius = 0;
            else
                siticoneElipse1.BorderRadius = 6;
        }
        #endregion
        private void addP_Click(object sender, EventArgs e)
        {
            //if (pname.Text != null)
            //{
            //    MutationClass.ProcessesList.Add(pname.Text);
            //    iLabel48.Text = "Added : " + pname.Text;
            //}
            //foreach(string str in MutationClass.ProcessesList)
            //MessageBox.Show(str);
        }
    }
}