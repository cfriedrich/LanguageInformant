using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Scene
    {
        public int SceneId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PictureId { get; set; }
    }
}
