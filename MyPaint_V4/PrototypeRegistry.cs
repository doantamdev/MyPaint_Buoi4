using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V4
{
    internal class PrototypeRegistry : Prototype
    {
        private Dictionary<string, Prototype> items;

        public PrototypeRegistry()
        {
            items = new Dictionary<string, Prototype>();
        }

        public void AddItem(string id,Prototype p)
        {
            items[id] = p;
        }


        public Prototype Clone(int x, int y, int width, int height, int borderwidth, Color borderColor)
        {
            throw new NotImplementedException();
        }

        public Prototype GetByColor(Color color)
        {
            foreach (var item in items.Values)
            {
                if (item.GetColor() == color.Name)
                {
                    return item;
                }
            }
            return null;
        }

        public Prototype GetByID(string id)
        {
            if (items.ContainsKey(id))
            {
                return items[id];
            }
            return null;
        }

        public string GetColor()
        {
            return null;
        }
    }
}
