# Image Meister
## Introduction
This is a simple Winfows only image viewer written in C# winforms designed specifically for reading consecutive image files or manga, it abuses the web browser control in winforms and uses its built-in async functionality to display large amounts of images efficiently.

## Usage
Download the executable from [here](https://github.com/blahlicus/image-meister/raw/master/Simple-Image-Meister/Simple-Image-Meister/Simple-Image-Meister/bin/Release/Simple-Image-Meister.exe), then add a file association to the executable by right-clicking an image and selecting "open with -> another application -> browse for an application" then select the downloaded .exe.

Alternatively, drag-and-drop image files directly onto the exe also works.

Or you could call it from the command line via the statement `image-meister.exe [image-path]`.

## Features
* Fast async image loading
* Display multiple images from the same folder from top to bottom
* Natural sorting of filenames when multiple images are displayed

## Why

Windows 10's default new photo viewer sucks as it has floating elements on top of the displayed image and file navigation in that application does not work every well, a wrong button press in the default Windows 10 photo viewer also messes up the image file's "data modified" metadata which may have been useful for sorting purposes. This replacement image viewer is good for displaying single images as well as for reading manga/doujinshis.

## Why is it in WinForms

I was lazy and I made this for myself.
