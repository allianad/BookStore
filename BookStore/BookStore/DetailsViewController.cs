using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    public partial class DetailsViewController : UIViewController
    {
        public Book selectedBook;
        public DetailsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            bookLabel.Text = selectedBook.Name;
            bookImageView.Image = UIImage.FromFile(selectedBook.ImagePath);
        }
    }
}