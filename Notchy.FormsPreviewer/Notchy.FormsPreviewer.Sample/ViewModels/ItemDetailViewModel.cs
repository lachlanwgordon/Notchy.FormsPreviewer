using System;

using Notchy.FormsPreviewer.Sample.Models;

namespace Notchy.FormsPreviewer.Sample.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
