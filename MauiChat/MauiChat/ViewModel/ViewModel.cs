using Syncfusion.Maui.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiChat
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<object> messages;

        /// <summary>
        /// current user of chat.
        /// </summary>
        private Author currentUser;
        #endregion

        #region Constructor
        public ViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Nancy", Avatar = "peoplecircle16.png" };
            this.GenerateMessages();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the group message conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current author.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }
        #endregion

        #region INotifyPropertyChanged
        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion

        #region Message Generation
        private void GenerateMessages()
        {
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Andrea", Avatar = "peoplecircle7.png" },
                Text = "Oh! That's great.",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison", Avatar = "peoplecircle1.png" },
                Text = "That is good news.",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Stevan", Avatar = "peoplecircle2.png" },
                Text = "What kind of application is it and when are we going to launch?",
            });
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "A kind of Emergency Broadcast App.",
            });
        }
        #endregion
    }
}
