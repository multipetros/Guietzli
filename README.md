# Guietzli
## v1.1
Copyright (C) 2017-2018, Petros Kyladitis  

## Description
An MS Windows graphic front-end for the [Google Guetzli JPEG Encoder](https://github.com/google/guetzli).  
  
Guetzli is an advanced JPEG encoder, with a complete new psycho-optical model, introduced by Google, claims better visual result with smaller file size. And it's 100% compatible with the [JPEG format](https://jpeg.org/jpeg/).  
  
Google provide a command line tool for the Guetzli encoder, although with this Windows front-end you can easily put files to an encode queue, select the output folder and the encoding quality.  
  
For updates and more info see at <http://multipetros.gr/>  

## Requirements
This program is designed for MS Windows with [.NET Framework 4.5](https://www.microsoft.com/en-us/download/details.aspx?id=30653) installed.

## Screenshots
![Screenshot](https://raw.githubusercontent.com/multipetros/Guietzli/master/screenshot.png)

## Usage
- Starting, add images files to the queue list by pressing the __Add Files__ button, __Drag-n-drop__ files from Desktop or Windows Explorer.
- You can multiple select inserted items to remove them from the list.
- After that you can select the output folder you by pressing the __Output Folder__ button, or menu, or __Drag-n-drop__ folder from Desktop or Windows Explorer.
- You can also select the encoding quality. The default value `84` is the standard quality, but you can increase it to `110` of [libjpeg-turbo](http://libjpeg-turbo.virtualgl.org/) score process starts automatically.
- To start the encoding process just press the __Start__ button.
- Please be patient. The Guetzli encoder gets a significant lot of time _(and memory)_ to do the encoding.
- If you want to interrupt the process, you can press the __Stop__ button.

## Download
 * [Setup package](https://github.com/multipetros/Guietzli/releases/download/v1.1/guietzli_1.1-setup.exe)
 * [Portable in zip archive](https://github.com/multipetros/Guietzli/releases/download/v1.1/guietzli_1.1-bin.zip)

## Change Log
### v1.1
 * Moved to .NET Framework 4.5, to be compatible, the encoder download functionality, with TLS 1.2 which now used by GitHub
### v1.0
 * Initial release
 
## License
This program is free software distributed under the GNU GPL 3, for license details see at `license.txt` file, distributed with this program, or see at <http://www.gnu.org/licenses/>.  

## Donations
If you think that this program is helpful for you and you are willing to support the developer, feel free to  make a donation through [PayPal](https://www.paypal.me/PKyladitis).  

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.me/PKyladitis)


