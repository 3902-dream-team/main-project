﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    public interface ILinkState
    {
        ILink Link { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
    }
}
