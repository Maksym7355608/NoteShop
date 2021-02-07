using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteShop.BLL.Interfaces
{
    public interface ISender
    {
        void SendInformationMessage(Order order);

    }
}
