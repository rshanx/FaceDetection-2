﻿using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;
using NDatabase.Api;

namespace FaceDetection.Core
{
    public class Human
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        [NonPersistent]
        public List<Image<Gray, byte>> ImagesEmgu;

        public Human(int id, string name, List<Image<Gray, byte>> images)
        {
            Id = id;
            Name = name;
            ImagesEmgu = new List<Image<Gray, byte>>(images);
        }
    }
}