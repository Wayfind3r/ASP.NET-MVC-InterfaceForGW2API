using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterfaceGW2Api.Models
{
    public class InfusionSlot
    {
        [Display(Name = "Infusion Slot Flags")]
        public List<string> flags { get; set; }
    }

    public class Buff
    {
        [Display(Name = "Skill Id")]
        public int skill_id { get; set; }
        [Display(Name = "Buff Description")]
        public string description { get; set; }
    }

    public class InfixUpgrade
    {
        [Display(Name = "Buff")]
        public Buff buff { get; set; }
        [Display(Name = "Attributes")]
        public List<object> attributes { get; set; }
    }

    public class Details
    {
        [Display(Name = "Type")]
        public string type { get; set; }
        [Display(Name = "Damage Type")]
        public string damage_type { get; set; }
        [Display(Name = "Min Power")]
        public int min_power { get; set; }
        [Display(Name = "Max Power")]
        public int max_power { get; set; }
        [Display(Name = "Defense")]
        public int defense { get; set; }
        [Display(Name = "Infusion Slots")]
        public List<InfusionSlot> infusion_slots { get; set; }
        [Display(Name = "Upgrades")]
        public InfixUpgrade infix_upgrade { get; set; }
        [Display(Name = "Duration")]
        public int duration_ms { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Suffix Item Id")]
        public int suffix_item_id { get; set; }
        [Display(Name = "Secondary Suffix Item Id")]
        public string secondary_suffix_item_id { get; set; }
        [Display(Name = "Flags")]
        public List<string> flags { get; set; }
        [Display(Name = "Infusion Upgrade Flags")]
        public List<string> infusion_upgrade_flags { get; set; }
        [Display(Name = "Minipet Id")]
        public int minipet_id { get; set; }
        [Display(Name = "Unlock Type")]
        public string unlock_type { get; set; }
        [Display(Name = "Recipe Id")]
        public int recipe_id { get; set; }
        [Display(Name = "Suffix")]
        public string suffix { get; set; }
        [Display(Name = "Weight Class")]
        public string weight_class { get; set; }
    }

    public class CompleteItemViewModel
    {
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Trading Post Prices")]
        public ItemPrices ItemPrices { get; set; }
        [Display(Name = "Type")]
        public string type { get; set; }
        [Display(Name = "Level Required")]
        public int level { get; set; }
        [Display(Name = "Rarity")]
        public string rarity { get; set; }
        [Display(Name = "Vendor Value")]
        public int vendor_value { get; set; }
        [Display(Name = "Skin Id")]
        public string default_skin { get; set; }
        [Display(Name = "Game mode availability")]
        public List<string> game_types { get; set; }
        [Display(Name = "Flags")]
        public List<string> flags { get; set; }
        [Display(Name = "Restrictions")]
        public List<object> restrictions { get; set; }
        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "Chat Link")]
        public string chat_link { get; set; }
        [Display(Name = "Icon")]
        public string icon { get; set; }
        [Display(Name = "Details")]
        public Details details { get; set; }

        public ListingChartViewModel ListingChartViewModel { get; set; }
        public string ReturnUrl { get; set; }
    }
}