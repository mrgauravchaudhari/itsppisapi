using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly TreeMenuRepository _repository;

        public MenuController(TreeMenuRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/Menu/routes
        [HttpPut]
        [Route("route")]
        public async Task<ActionResult<IEnumerable<PPV_ROUTEMENU>>> PutRoute(NumberParameterDto data)
        {
            return await _repository.GetAllRoutes(data);
        }

        // GET api/Menu/tree
        [HttpPut]
        public async Task<ActionResult<IEnumerable<PPV_TREEMENU>>> Put(NumberParameterDto data)
        {
            IEnumerable<PPV_TREEMENU> menuData;
            IEnumerable<PPV_TREEMENU> _menuParentNodesData;

            menuData = await _repository.GetAll(data);

            if (menuData != null && menuData.Count() > 1)
            {
                _menuParentNodesData = menuData.Where(menu => menu.PARENT_MODULE_NAME == "PARENT");

                foreach (var menuItem in _menuParentNodesData)
                {
                    buildTreeviewMenu(menuItem, menuData);
                }
            }
            else
                _menuParentNodesData = new PPV_TREEMENU[] { };
            return _menuParentNodesData.ToList();
        }

        private void buildTreeviewMenu(PPV_TREEMENU menuItem, IEnumerable<PPV_TREEMENU> menudata)
        {
            IEnumerable<PPV_TREEMENU> _menuItems;

            _menuItems = menudata.Where(menu => menu.PARENT_MODULE_NAME == menuItem.MODULE_NAME);

            if (_menuItems != null && _menuItems.Count() > 0)
            {
                foreach (var item in _menuItems)
                {
                    menuItem.Categories.Add(item);
                    buildTreeviewMenu(item, menudata);
                }
            }
        }
    }
}
