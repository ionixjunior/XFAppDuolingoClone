using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Enums;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Fakes
{
    public class StoreServiceFake : IStoreService
    {
        public async Task<IList<StoreItemGroup>> GetItems()
        {
            return await Task.Run(() =>
            {
                var storeItems = GetStoreItems();
                return GroupStoreItems(storeItems);
            });
        }

        private List<StoreItem> GetStoreItems()
        {
            return new List<StoreItem>
            {
                GetStoreItem(
                    "store_item_1",
                    "Dobro ou nada",
                    "Dobre sua aposta de 50 cristais mantendo 7 dias de ofensiva.",
                    50,
                    StoreItemType.Sell,
                    "Superpoderes"
                ),
                GetStoreItem(
                    "store_item_2",
                    "Bloqueio de ofensivas",
                    "O bloqueio de ofensivas faz com que o número de ofensivas não caia mesmo que você fique inativo por um dia.",
                    200,
                    StoreItemType.Sell,
                    "Superpoderes"
                ),
                GetStoreItem(
                    "store_item_3",
                    "Vidas ilimitadas",
                    "Nunca fique sem vidas com o Duolingo Plus!",
                    null,
                    StoreItemType.Ads,
                    "Superpoderes"
                ),
                GetStoreItem(
                    "store_item_4",
                    "Refil de vidas",
                    "Recupere suas vidas para você se preocupar menos em cometer erros em uma lição",
                    null,
                    StoreItemType.Normal,
                    "Superpoderes"
                ),
                GetStoreItem(
                    "store_item_5",
                    "Traje formal",
                    "Aprendendo com estilo. Duo sempre foi uma cara impecável. Agora ele vai andar impecável também.",
                    400,
                    StoreItemType.Sell,
                    "Trajes"
                ),
                GetStoreItem(
                    "store_item_6",
                    "Traje esportivo dourado",
                    "Aprendendo com luxo. Duo vai amar sentir o ouro de 24 quilates em suas penas.",
                    600,
                    StoreItemType.Sell,
                    "Trajes"
                ),
                GetStoreItem(
                    "store_item_7",
                    "Super Duo",
                    "Transforme a humilde coruja que o Duo é em um poderoso herói que luta contra o crime.",
                    1000,
                    StoreItemType.Sell,
                    "Trajes"
                ),
                GetStoreItem(
                    "store_item_8",
                    "Expressões e Ditados",
                    "Aprenda expressões idiomáticas em Inglês.",
                    1000,
                    StoreItemType.Sell,
                    "Unidades Bônus"
                ),
                GetStoreItem(
                    "store_item_9",
                    "Cantadas",
                    "Você acredita em amor à primeira vista? Aprenda algumas cantadas em Inglês.",
                    1000,
                    StoreItemType.Sell,
                    "Unidades Bônus"
                )
            };
        }

        private static StoreItem GetStoreItem(
            string icon,
            string name,
            string description,
            int? price,
            StoreItemType type,
            string groupName)
        {
            return new StoreItem {
                Icon = icon,
                Name = name,
                Description = description,
                Price = price,
                Type = type,
                GroupName = groupName
            };
        }

        private List<StoreItemGroup> GroupStoreItems(List<StoreItem> storeItems)
        {
            return storeItems
                    .GroupBy(item => item.GroupName)
                    .Select(group => new StoreItemGroup(group.Key, group.ToList()))
                    .ToList();
        }
    }
}
