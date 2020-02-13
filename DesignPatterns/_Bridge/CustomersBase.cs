﻿using System;

namespace DesignPatterns._Bridge
{
    // Abstraction Class
    public class CustomersBase
    {
        private DataObject dataObject;
        protected string group;

        public CustomersBase(string group)
        {
            this.group = group;
        }
        
        // Property
        public DataObject Data
        {
            set
            {
                dataObject = value;
            }
            get
            {
                return dataObject;
            }
        }

        public virtual void Next()
        {
            dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + group);
            dataObject.ShowAllRecord();
        }
    }
}