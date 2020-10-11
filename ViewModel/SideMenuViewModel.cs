using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu
{
    public class SideMenuViewModel
    {

        public SideMenuViewModel()
        {
            allMenuItems = new List<MenuItem>();

            AddMenuItem(new MenuData() { Id = 1, ParentId = 0, Caption = "DashBoard" });


            AddMenuItem(new MenuData() { Id = 2, ParentId = 1, Caption = "DashBoard 2" });
        }


        public void AddMenuItem(MenuData data)
        {
            var item = new MenuItem(data);

            if (!string.IsNullOrEmpty(data.Uri))
            {
                item.Command = new DelegateCommand<string>(Navigate);
                item.CmdParameter = data.Uri;
            }
            if (data.ParentId != 0)
            {
                MenuItem parent = allMenuItems.Find(x => x.Id == data.ParentId);
                if (parent != null)
                {
                    item.Parent = parent;
                    parent.AddSubMenu(item);
                }
            }

            this.allMenuItems.Add(item);

        }

        public List<MenuItem> allMenuItems { get; set; }


        private void Navigate(string obj)
        {
            throw new NotImplementedException();
        }


        //Our Source List for Menu Items
        public List<MenuItem> MenuList
        {
            get
            {
                return GetParentMenuItems();

            }
        }


        public List<MenuItem> GetParentMenuItems()
        {
            List<MenuItem> parentItems = allMenuItems.FindAll(x => x.Parent == null);

            return parentItems;
        }
    }


    public class MenuItem : BindableBase
    {

        public DelegateCommand<string> Command { get; set; }

        public string Caption
        {
            get { return m_Caption; }
            set { m_Caption = value; RaisePropertyChanged(nameof(Caption)); }
        }
        string m_Caption;


        public string CmdParameter
        {
            get { return m_CmdParameter; }
            set { m_CmdParameter = value; RaisePropertyChanged(nameof(CmdParameter)); }
        }



        string m_CmdParameter;



        //private string name;

        //private string text;

        private List<MenuItem> subItems;

        //private DelegateCommand onSelected;

        private MenuItem parent;

        public MenuItem(MenuData menuData)
        {
            this.id = menuData.Id;
            this.Caption = menuData.Caption;
            this.subItems = new List<MenuItem>();
            //OnSelected = new DelegateCommand(ShowMessage, CanShowMessage);
        }


        public MenuItem(int _id, string text)
        {
            this.id = _id;
            this.Caption = text;
            this.subItems = new List<MenuItem>();
            //OnSelected = new DelegateCommand(ShowMessage, CanShowMessage);
        }


       

        public MenuItem(string name, string text)
        {
            //this.name = name;
            this.Caption = text;
            this.subItems = new List<MenuItem>();
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        //public string Name { get { return this.name; } }

        //public string Text { get { return this.text; } }

        public MenuItem Parent { get { return this.parent; } set { this.parent = value; } }

        //public DelegateCommand OnSelected
        //{
        //    get
        //    {
        //        if (this.onSelected == null)
        //        {
        //            this.onSelected = new DelegateCommand(this.OnItemSelected, this.ItemCanBeSelected);
        //        }
        //        return this.onSelected;
        //    }

        //    set { onSelected = value; }
        //}

        public List<MenuItem> SubItems
        {
            get
            {
                return this.subItems;
            }
        }

        public void AddSubMenu(MenuItem menuItem)
        {
            this.subItems.Add(menuItem);
        }

        public void RemoveSubMenu(MenuItem menuItem)
        {
            if (this.subItems.Contains(menuItem))
            {
                this.subItems.Remove(menuItem);
            }
        }

        public virtual void OnItemSelected() { }

        public virtual bool ItemCanBeSelected()
        {
            return true;
        }

    }






    public class MenuData
    {
        public MenuData()
        {
            RegionName = "MainContent";
        }
        public int Id { get; set; }
        public int ParentId { get; set; }

        public string CommandParmeter { get; set; }

        public string Caption { get; set; }
        public string RegionName { get; set; }

        public string Uri { get; set; }
    }










    //public class MenuItem
    //{
    //    //Icon Data
    //    public PathGeometry PathData { get; set; }
    //    public string Caption { get; set; }
    //    public List<MenuItem> SubMenuList { get; set; }

    //    //To Add click event to our Buttons we will use ICommand here to switch pages when specific button is clicked
    //    public MenuItem()
    //    {
    //        Command = new CommandViewModel(Execute);
    //    }

    //    public ICommand Command { get; }

    //    private void Execute()
    //    {
    //        //our logic comes here
    //        string MT = Caption.Replace(" ", string.Empty);
    //        if (!string.IsNullOrEmpty(MT))
    //            navigateToPage(MT);
    //    }

    //    private void navigateToPage(string Menu)
    //    {
    //        //We will search for our Main Window in open windows and then will access the frame inside it to set the navigation to desired page..
    //        //lets see how... ;)
    //        foreach (Window window in Application.Current.Windows)
    //        {
    //            if (window.GetType() == typeof(MainWindow))
    //            {
    //                (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
    //            }
    //        }
    //    }
    //}
    public class SubMenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public string SubMenuText { get; set; }

        //To Add click event to our Buttons we will use ICommand here to switch pages when specific button is clicked
        public SubMenuItemsData()
        {
            SubMenuCommand = new CommandViewModel(Execute);
        }

        public ICommand SubMenuCommand { get; }

        private void Execute()
        {
            //our logic comes here
            string SMT = SubMenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(SMT))
                navigateToPage(SMT);
        }

        private void navigateToPage(string Menu)
        {
            //We will search for our Main Window in open windows and then will access the frame inside it to set the navigation to desired page..
            //lets see how... ;)
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
}