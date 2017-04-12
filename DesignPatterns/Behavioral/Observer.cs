using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * When there are relationships between one or more objects, an observer will notify all the 
 * dependent elements when something is modified in the parent. Microsoft already 
 * implemented this pattern as ObservableCollection. Here let me implement the most basic 
 * Observer Pattern. 
 * 
 * You can definitely got the idea that after you Register for the Notification, you will 
 * get it when ChangeState is called.
 */

namespace DesignPatterns.Behavioral
{
    public delegate void NotifyChangeEventHandler(string notifyinfo);

    public interface IObservable
    {
        void Attach(NotifyChangeEventHandler ohandler);
        void Detach(NotifyChangeEventHandler ohandler);
        void Notify(string name);
    }

    public abstract class AbstractObserver : IObservable
    {
        public void Register(NotifyChangeEventHandler handler)
        {
            this.Attach(handler);
        }

        public void UnRegister(NotifyChangeEventHandler handler)
        {
            this.Detach(handler);
        }

        public virtual void ChangeState()
        {
            this.Notify("changestate");
        }

        #region IObservable Members

        public void Attach(NotifyChangeEventHandler ohandler)
        {
            this.NotifyChanged += ohandler;
        }

        public void Detach(NotifyChangeEventHandler ohandler)
        {
            this.NotifyChanged -= ohandler;
        }

        public void Notify(string name)
        {
            if(this.NotifyChanged != null)
            {
                this.NotifyChanged(name);
            }
        }

        #endregion

        #region INotifyChanged Members

        public event NotifyChangeEventHandler NotifyChanged;

        #endregion

    }

    public class Observer : AbstractObserver
    {
        public override void ChangeState()
        {
            base.ChangeState();
        }
    }
}
