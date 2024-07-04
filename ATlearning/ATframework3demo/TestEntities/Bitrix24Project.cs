using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.TestEntities
{
    public class Bitrix24Project
    {
        public Bitrix24Project(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
