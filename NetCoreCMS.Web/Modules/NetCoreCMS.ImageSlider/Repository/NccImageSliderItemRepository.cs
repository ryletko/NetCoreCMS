/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.Mvc.Repository;
using NetCoreCMS.ImageSlider.Models;

namespace NetCoreCMS.ImageSlider.Repository
{    
    public class NccImageSliderItemRepository : BaseRepository<NccImageSliderItem, long>
    {
        public NccImageSliderItemRepository(NccDbContext context) : base(context)
        {
        }
    }
}
