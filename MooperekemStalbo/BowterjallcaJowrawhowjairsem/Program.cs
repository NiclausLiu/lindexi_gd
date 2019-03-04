﻿using System;
using System.IO;
using MooperekemStalbo.Controllers;

namespace BowterjallcaJowrawhowjairsem
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(folder, "WeserefairsouWorlokeqa.zip");
            folder = Path.Combine(folder, "temp");
            if (Directory.Exists(folder))
            {
                Directory.Delete(folder, true);
            }

            Directory.CreateDirectory(folder);

            // 判断上传的文件是否可以
            var medaltraFairjousuFowluNererisMoubeturce = new MedaltraFairjousuFowluNererisMoubeturce();
            medaltraFairjousuFowluNererisMoubeturce.Folder = folder;

            medaltraFairjousuFowluNererisMoubeturce.CheckFile(new FileInfo(file));
        }
    }
}