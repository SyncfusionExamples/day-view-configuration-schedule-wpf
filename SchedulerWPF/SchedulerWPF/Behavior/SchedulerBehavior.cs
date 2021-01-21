using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.DisplayDate = DateTime.Now.Date.AddHours(11);
            this.AssociatedObject.MinimumDate = DateTime.Now.Date;
            this.AssociatedObject.MaximumDate = DateTime.Now.Date;
        }        
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.scheduler = null;
        }
    }
}