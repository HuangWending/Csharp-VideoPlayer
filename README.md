# Csharp-VideoPlayer
C#视频播放器
using System;: 导入System命名空间，包含了一些常用的系统类型和方法。

using System.Windows.Forms;: 导入System.Windows.Forms命名空间，包含了Windows窗体应用程序开发所需的类型和方法。

using System.IO;: 导入System.IO命名空间，包含了对文件和目录进行操作的类型和方法。

using WMPLib;: 导入WMPLib命名空间，包含了使用Windows Media Player COM组件的类型和方法。

namespace VideoPlayer: 创建了一个名为VideoPlayer的命名空间，用于组织代码。

public partial class MainForm : Form: 定义了一个名为MainForm的窗体类，继承自Form类。该类是应用程序的主窗体。

private WindowsMediaPlayer mediaPlayer;: 声明了一个名为mediaPlayer的私有成员变量，类型为WindowsMediaPlayer。该变量将用于控制视频播放。

public MainForm(): MainForm类的构造函数。在构造函数中完成了初始化工作。

InitializeComponent(): 自动生成的方法，用于初始化窗体和控件。

mediaPlayer = new WindowsMediaPlayer();: 创建一个WindowsMediaPlayer对象，并将其赋给mediaPlayer变量。

private void SelectVideoButton_Click(object sender, EventArgs e): 选择视频按钮的点击事件处理程序。

OpenFileDialog openFileDialog = new OpenFileDialog();: 创建一个OpenFileDialog对象，用于选择视频文件。

openFileDialog.Filter = "Video Files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv|All files (*.*)|*.*";: 设置文件对话框的过滤器，限制只显示视频文件。

if (openFileDialog.ShowDialog() == DialogResult.OK): 当用户点击确定按钮选择了视频文件后执行以下代码块。

string selectedVideoPath = openFileDialog.FileName;: 获取所选视频文件的路径。

mediaPlayer.URL = selectedVideoPath;: 将所选视频文件的路径赋给mediaPlayer对象的URL属性，以便播放该视频。

private void PlayButton_Click(object sender, EventArgs e): 播放按钮的点击事件处理程序。

mediaPlayer.controls.play();: 调用mediaPlayer对象的controls.play()方法，开始播放视频。

private void PauseButton_Click(object sender, EventArgs e): 暂停按钮的点击事件处理程序。

mediaPlayer.controls.pause();: 调用mediaPlayer对象的controls.pause()方法，暂停视频播放。

private void SpeedTrackBar_Scroll(object sender, EventArgs e): 速度滑块的滚动事件处理程序。

mediaPlayer.settings.rate = SpeedTrackBar.Value / 10.0;: 将滑块的值除以10，然后将结果赋给mediaPlayer对象的settings.rate属性。该属性用于控制视频的播放速度。

private void VolumeTrackBar_Scroll(object sender, EventArgs e): 音量滑块的滚动事件处理程序。

mediaPlayer.settings.volume = VolumeTrackBar.Value;: 将滑块的值赋给mediaPlayer对象的settings.volume属性。该属性用于控制视频的音量。
