using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using NReco.VideoConverter;

//Notes: This program can be used with any video, it jsut dont play any sound

namespace VideoPlay
{
    class Program 
    {
        static void Main(string[]args){

            string FileName = "bad_apple.mp4";
            Console.WriteLine("Video playing...");
            using(var read = new FFMpegConverter())
            {
                int frameIndex = 0:

                while(true)
                {
                    var outputPath = $"tmp_frame_{frameIndex:D4}.png";

                    //actual photoframe

                    read.GetVideoThumbnail(FineName, outputPath, frameIndex, 1, VideoCodec.Mpeg4);

                    if(!FileName.Exists(outputPath))
                        break;  

                    var frameImage = 

                    
                }
            }

        } 

    }
}

