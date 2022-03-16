using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class Item
    {
		private string _name;
		private string _description;
		private int _roomid;
		private bool _herring;

		public Item(string n, string d, int r, bool h)
		{
			_name = n;
			_description = d;
			_roomid = r;
			_herring = h;
		}
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}


		public int RoomID
		{
			get
			{
				return _roomid;
			}
			set
			{
				_roomid = value;
			}
		}

		public bool Herring
		{
			get
			{
				return _herring;
			}
			set
			{
				_herring = value;
			}
		}

		public void PrintItem()
        {
			Console.WriteLine(_name + ". " + _description + " From room " + _roomid);
        }
	}
}
