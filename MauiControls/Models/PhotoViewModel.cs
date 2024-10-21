using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    class PhotoViewModel
    {
        private ObservableCollection<Photo> _photos;
        public ObservableCollection<Photo> Photos {
            get => _photos;
            set => _photos = value;
        }

        public PhotoViewModel()
        {
            _photos = new ObservableCollection<Photo>
            {
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Andromeda", ImageUrl="galaxies/galaxy1.jpg" },
                new Photo { Name="Milky Way", ImageUrl="galaxies/galaxy2.webp" },
                new Photo { Name="Universe", ImageUrl="galaxies/galaxy3.jpg" },
                new Photo { Name="Galaxy", ImageUrl="galaxies/galaxy4.webp" },
                new Photo { Name="Sombrero", ImageUrl="galaxies/galaxy5.jpg" }
            };
        }
    }
}
