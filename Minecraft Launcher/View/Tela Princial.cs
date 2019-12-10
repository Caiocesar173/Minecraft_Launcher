using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using Minecraft_Launcher.View;
using Minecraft_Launcher.Model;

namespace Minecraft_Launcher
{
    public partial class Tela_Principal : Form
    {
        public static bool FullScreen;
        public static bool Altura;
        public static bool Largura;


        public static int altura;
        public static int largura;
        private string args;
               

        public Tela_Principal()
        {
            InitializeComponent();
        }

       

        private void Nick_Name_Leave(object sender, EventArgs e)
        {
            Nick_Name.HintText = "Seu Nick Name";
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Nome Invalido 
            if (Nick_Name.Text.ToUpper() == "USERNAME" || Nick_Name.Text.ToUpper() == "NICK")
            {
                Label_Error.Text = "*Nome de Usuario Invalido";
                Label_Error.Visible = true;
            }
            else
            {
                Label_Error.Visible = false;
            }
            //Nome Invalido Fim

            //Nome Vazio
            if (Nick_Name.Text == "")
            {
                Label_Error.Text = "*O campo Nick deve ser preenchido";
                Label_Error.Visible = true;
                Nick_Name.Text = "";
            }
            else
            {
                Label_Error.Visible = false;

            }
            //Nome Vazio Fim


            string uuid = UUID(Nick_Name.Text);
            string gameVersion = "1.14.4";
            var date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
            DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).AddMonths(2).ToString() + " -200";

            

            string usercache = "[{\"name\":"+ Nick_Name.Text +",\"uuid\":"+ uuid + ",\"expiresOn\":"+ date +"}]";

            args = @" -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -Xmx2048m -Djava.net.preferIPv4Stack=true -javaagent:C:\Users\happycode1\AppData\Roaming\.minecraft\launcher.jar -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=C:\Users\happycode1\AppData\Roaming\.minecraft\versions\" + gameVersion + @"\" + gameVersion + @"-natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=3.0-56b87f6 -cp C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\javabridge\1.0.22\javabridge-1.0.22.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\google\guava\guava\21.0\guava-21.0.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\brigadier\1.0.17\brigadier-1.0.17.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\datafixerupper\2.0.24\datafixerupper-2.0.24.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\it\unimi\dsi\fastutil\8.2.1\fastutil-8.2.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl\3.2.2\lwjgl-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.2.2\lwjgl-jemalloc-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.2.2\lwjgl-openal-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.2.2\lwjgl-opengl-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.2.2\lwjgl-glfw-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.2.2\lwjgl-stb-3.2.2.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\libraries\com\mojang\text2speech\1.11.3\text2speech-1.11.3.jar;C:\Users\happycode1\AppData\Roaming\.minecraft\versions\" + gameVersion + @"\" + gameVersion + @".jar net.minecraft.client.main.Main --username " + Nick_Name.Text + @" --version " + gameVersion + @" --gameDir C:\Users\happycode1\AppData\Roaming\.minecraft --assetsDir C:\Users\happycode1\AppData\Roaming\.minecraft\assets --assetIndex 1.14 --uuid ca5cd53a25e236b2839ad8948e3ab264 --accessToken 2ce914d47bc654574c484c1d849177e9 --userType mojang --versionType release";
            if (FullScreen)
            {
                args = args + " --fullscreen";
            }


            //Process Handling s
            Process Minecraft = new Process();
            Minecraft.StartInfo.FileName = @"C:\Program Files\Java\jre1.8.0_221\bin\javaw.exe";
            Minecraft.StartInfo.CreateNoWindow = false;
            Minecraft.StartInfo.Arguments = args;

            Minecraft.Refresh(); // Important
            Minecraft.Start();

            
            Console.WriteLine(usercache);

        }


        private string UUID(string Nick)
        {
            string UUID;
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(Nick));
                Guid result = new Guid(hash);
                //Console.WriteLine(result);
                UUID = Convert.ToString(result);
            }
            return UUID;
        }  
        
        private void Nick_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(this, new EventArgs());
            }
        }

        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            Tela_Settings Settings = new Tela_Settings();
            Settings.ShowDialog();
        }
    }
}
