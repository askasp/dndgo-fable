module App.jsonStrings

    let classjson = """
    [
        {
            "index": 1,
            "name": "Barbarian",
            "hit_die": 12,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/106",
                            "name": "Skill: Animal Handling"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/115",
                            "name": "Skill: Nature"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/122",
                            "name": "Skill: Survival"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Medium armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/2"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Martial weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/20"
                }
            ],
            "saving_throws": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1"
                },
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/1",
                "class": "Barbarian"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/barbarian/levels",
                "class": "Barbarian"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/1",
                    "name": "Berserker"
                }
            ],
            "spellcasting": {
                
            },
            "url": "http://www.dnd5eapi.co/api/classes/1"
        },
        {
            "index": 2,
            "name": "Bard",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 3,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/105",
                            "name": "Skill: Acrobatics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/106",
                            "name": "Skill: Animal Handling"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/107",
                            "name": "Skill: Arcana"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/109",
                            "name": "Skill: Deception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/113",
                            "name": "Skill: Investigation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/114",
                            "name": "Skill: Medicine"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/115",
                            "name": "Skill: Nature"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/117",
                            "name": "Skill: Performance"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/118",
                            "name": "Skill: Persuasion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/120",
                            "name": "Skill: Sleight of Hand"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/121",
                            "name": "Skill: Stealth"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/122",
                            "name": "Skill: Survival"
                        }
                    ]
                },
                {
                    "choose": 3,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/81",
                            "name": "Bagpipes"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/82",
                            "name": "Drum"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/83",
                            "name": "Dulcimer"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/84",
                            "name": "Flute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/85",
                            "name": "Lute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/86",
                            "name": "Lyre"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/87",
                            "name": "Horn"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/88",
                            "name": "Pan flute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/89",
                            "name": "Shawm"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/90",
                            "name": "Viol"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Longswords",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/42"
                },
                {
                    "name": "Rapiers",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/46"
                },
                {
                    "name": "Shortswords",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/48"
                },
                {
                    "name": "Crossbows, hand",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/54"
                }
            ],
            "saving_throws": [
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2"
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/2",
                "class": "Bard"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/bard/levels",
                "class": "Bard"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/2",
                    "name": "Lore"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/1",
                "class": "Bard"
            },
            "url": "http://www.dnd5eapi.co/api/classes/2"
        },
        {
            "index": 3,
            "name": "Cleric",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/114",
                            "name": "Skill: Medicine"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/118",
                            "name": "Skill: Persuasion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Medium armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/2"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                }
            ],
            "saving_throws": [
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5"
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/3",
                "class": "Cleric"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/cleric/levels",
                "class": "Cleric"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/3",
                    "name": "Life"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/2",
                "class": "Cleric"
            },
            "url": "http://www.dnd5eapi.co/api/classes/3"
        },
        {
            "index": 4,
            "name": "Druid",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/106",
                            "name": "Skill: Animal Handling"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/107",
                            "name": "Skill: Arcana"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/114",
                            "name": "Skill: Medicine"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/115",
                            "name": "Skill: Nature"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/122",
                            "name": "Skill: Survival"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Medium armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/2"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Clubs",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/21"
                },
                {
                    "name": "Daggers",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/22"
                },
                {
                    "name": "Javelins",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/25"
                },
                {
                    "name": "Maces",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/27"
                },
                {
                    "name": "Quarterstaffs",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/28"
                },
                {
                    "name": "Sickles",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/29"
                },
                {
                    "name": "Spears",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/30"
                },
                {
                    "name": "Darts",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/32"
                },
                {
                    "name": "Slings",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/34"
                },
                {
                    "name": "Scimitars",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/47"
                },
                {
                    "name": "Herbalism Kit",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/93"
                }
            ],
            "saving_throws": [
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4"
                },
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/4",
                "class": "Druid"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/druid/levels",
                "class": "Druid"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/4",
                    "name": "Land"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/3",
                "class": "Druid"
            },
            "url": "http://www.dnd5eapi.co/api/classes/4"
        },
        {
            "index": 5,
            "name": "Fighter",
            "hit_die": 10,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/105",
                            "name": "Skill: Acrobatics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/106",
                            "name": "Skill: Animal Handling"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/122",
                            "name": "Skill: Survival"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "All armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/4"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Martial weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/20"
                }
            ],
            "saving_throws": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1"
                },
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/5",
                "class": "Fighter"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/fighter/levels",
                "class": "Fighter"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/5",
                    "name": "Champion"
                }
            ],
            "spellcasting": {
                
            },
            "url": "http://www.dnd5eapi.co/api/classes/5"
        },
        {
            "index": 6,
            "name": "Monk",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 1,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/58",
                            "name": "Alchemist's supplies"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/59",
                            "name": "Brewer's supplies"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/60",
                            "name": "Calligrapher's supplies"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/61",
                            "name": "Carpenter's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/62",
                            "name": "Cartographer's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/63",
                            "name": "Cobbler's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/64",
                            "name": "Cook's utensils"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/65",
                            "name": "Glassblower's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/66",
                            "name": "Jeweler's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/67",
                            "name": "Leatherworker's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/68",
                            "name": "Mason's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/69",
                            "name": "Painter's supplies"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/70",
                            "name": "Potter's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/71",
                            "name": "Smith's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/72",
                            "name": "Tinker's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/73",
                            "name": "Weaver's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/74",
                            "name": "Woodcarver's tools"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/75",
                            "name": "Disguise kit"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/76",
                            "name": "Forgery kit"
                        }
                    ]
                },
                {
                    "choose": 1,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/81",
                            "name": "Bagpipes"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/82",
                            "name": "Drum"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/83",
                            "name": "Dulcimer"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/84",
                            "name": "Flute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/85",
                            "name": "Lute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/86",
                            "name": "Lyre"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/87",
                            "name": "Horn"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/88",
                            "name": "Pan flute"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/89",
                            "name": "Shawm"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/90",
                            "name": "Viol"
                        }
                    ]
                },
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/105",
                            "name": "Skill: Acrobatics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/121",
                            "name": "Skill: Stealth"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Shortswords",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/48"
                }
            ],
            "saving_throws": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1"
                },
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/6",
                "class": "Monk"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/monk/levels",
                "class": "Monk"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/6",
                    "name": "Open Hand"
                }
            ],
            "spellcasting": {
                
            },
            "url": "http://www.dnd5eapi.co/api/classes/6"
        },
        {
            "index": 7,
            "name": "Paladin",
            "hit_die": 10,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/114",
                            "name": "Skill: Medicine"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/118",
                            "name": "Skill: Persuasion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "All armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/4"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Martial weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/20"
                }
            ],
            "saving_throws": [
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5"
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/7",
                "class": "Paladin"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/paladin/levels",
                "class": "Paladin"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/7",
                    "name": "Devotion"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/4",
                "class": "Paladin"
            },
            "url": "http://www.dnd5eapi.co/api/classes/7"
        },
        {
            "index": 8,
            "name": "Ranger",
            "hit_die": 10,
            "proficiency_choices": [
                {
                    "choose": 3,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/106",
                            "name": "Skill: Animal Handling"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/113",
                            "name": "Skill: Investigation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/115",
                            "name": "Skill: Nature"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/121",
                            "name": "Skill: Stealth"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/122",
                            "name": "Skill: Survival"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Medium armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/2"
                },
                {
                    "name": "Shields",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/18"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Martial weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/20"
                }
            ],
            "saving_throws": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1"
                },
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/8",
                "class": "Ranger"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/ranger/levels",
                "class": "Ranger"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/8",
                    "name": "Hunter"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/5",
                "class": "Ranger"
            },
            "url": "http://www.dnd5eapi.co/api/classes/8"
        },
        {
            "index": 9,
            "name": "Rogue",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 4,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/105",
                            "name": "Skill: Acrobatics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/108",
                            "name": "Skill: Athletics"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/109",
                            "name": "Skill: Deception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/113",
                            "name": "Skill: Investigation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                            "name": "Skill: Perception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/117",
                            "name": "Skill: Performance"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/118",
                            "name": "Skill: Persuasion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/120",
                            "name": "Skill: Sleight of Hand"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/121",
                            "name": "Skill: Stealth"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                },
                {
                    "name": "Longswords",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/42"
                },
                {
                    "name": "Rapiers",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/46"
                },
                {
                    "name": "Shortswords",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/48"
                },
                {
                    "name": "Crossbows, hand",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/54"
                },
                {
                    "name": "Thieves' Tools",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/96"
                }
            ],
            "saving_throws": [
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2"
                },
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/9",
                "class": "Rogue"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/rogue/levels",
                "class": "Rogue"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/9",
                    "name": "Thief"
                }
            ],
            "spellcasting": {
                
            },
            "url": "http://www.dnd5eapi.co/api/classes/9"
        },
        {
            "index": 10,
            "name": "Sorcerer",
            "hit_die": 6,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/107",
                            "name": "Skill: Arcana"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/109",
                            "name": "Skill: Deception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/118",
                            "name": "Skill: Persuasion"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Daggers",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/22"
                },
                {
                    "name": "Quarterstaffs",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/28"
                },
                {
                    "name": "Darts",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/32"
                },
                {
                    "name": "Slings",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/34"
                }
            ],
            "saving_throws": [
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3"
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/10",
                "class": "Sorcerer"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/sorcerer/levels",
                "class": "Sorcerer"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/10",
                    "name": "Draconic"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/6",
                "class": "Sorcerer"
            },
            "url": "http://www.dnd5eapi.co/api/classes/10"
        },
        {
            "index": 11,
            "name": "Warlock",
            "hit_die": 8,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/107",
                            "name": "Skill: Arcana"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/109",
                            "name": "Skill: Deception"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/112",
                            "name": "Skill: Intimidation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/113",
                            "name": "Skill: Investigation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/115",
                            "name": "Skill: Nature"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Light armor",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/1"
                },
                {
                    "name": "Simple weapons",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/19"
                }
            ],
            "saving_throws": [
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5"
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/11",
                "class": "Warlock"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/warlock/levels",
                "class": "Warlock"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/11",
                    "name": "Fiend"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/7",
                "class": "Warlock"
            },
            "url": "http://www.dnd5eapi.co/api/classes/11"
        },
        {
            "index": 12,
            "name": "Wizard",
            "hit_die": 6,
            "proficiency_choices": [
                {
                    "choose": 2,
                    "jsontype": "proficiencies",
                    "from": [
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/107",
                            "name": "Skill: Arcana"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/110",
                            "name": "Skill: History"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/111",
                            "name": "Skill: Insight"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/113",
                            "name": "Skill: Investigation"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/114",
                            "name": "Skill: Medicine"
                        },
                        {
                            "url": "http://www.dnd5eapi.co/api/proficiencies/119",
                            "name": "Skill: Religion"
                        }
                    ]
                }
            ],
            "proficiencies": [
                {
                    "name": "Daggers",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/22"
                },
                {
                    "name": "Quarterstaffs",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/28"
                },
                {
                    "name": "Darts",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/32"
                },
                {
                    "name": "Slings",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/34"
                }
            ],
            "saving_throws": [
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4"
                },
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5"
                }
            ],
            "starting_equipment": {
                "url": "http://www.dnd5eapi.co/api/startingequipment/12",
                "class": "Wizard"
            },
            "class_levels": {
                "url": "http://www.dnd5eapi.co/api/classes/wizard/levels",
                "class": "Wizard"
            },
            "subclasses": [
                {
                    "url": "http://www.dnd5eapi.co/api/subclasses/12",
                    "name": "Evocation"
                }
            ],
            "spellcasting": {
                "url": "http://www.dnd5eapi.co/api/spellcasting/8",
                "class": "Wizard"
            },
            "url": "http://www.dnd5eapi.co/api/classes/12"
        }
    ]"""

    let racejson = """
    [
        {
            "index": 1,
            "name": "Dwarf",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {},
            "alignment": "Most dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.",
            "age": "Dwarves mature at the same rate as humans, but they're considered young until they reach the age of 50. On average, they live about 350 years.",
            "size": "Medium",
            "size_description": "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.",
            "starting_proficiencies": [
                {
                    "url": "http://www.dnd5eapi.co/api/proficiencies/20",
                    "name": "Battleaxes"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/proficiencies/24",
                    "name": "Handaxes"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/proficiencies/26",
                    "name": "Light hammers"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/proficiencies/51",
                    "name": "Warhammers"
                }
            ],
            "starting_proficiency_options": {
                "choose": 1,
                "type": "proficiencies",
                "from": [
                    {
                        "url": "http://www.dnd5eapi.co/api/proficiencies/71",
                        "name": "Smith's tools"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/proficiencies/59",
                        "name": "Brewer's supplies"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/proficiencies/68",
                        "name": "Mason's tools"
                    }
                ]
            },
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/2",
                    "name": "Dwarvish"
                }
            ],
            "language_options": {

            },
            "language_desc": "You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.",
            "traits": [
                {
                    "name": "Darkvision (Dwarf)",
                    "url": "http://www.dnd5eapi.co/api/traits/1"
                },
                {
                    "name": "Dwarven Resilience",
                    "url": "http://www.dnd5eapi.co/api/traits/2"
                },
                {
                    "name": "Stonecunning",
                    "url": "http://www.dnd5eapi.co/api/traits/3"
                }
            ],
            "subraces": [
                {
                    "url": "http://www.dnd5eapi.co/api/subraces/1",
                    "name": "Hill Dwarf"
                }
            ],
            "url": "http://www.dnd5eapi.co/api/races/1"
        },
        {
            "index": 2,
            "name": "Elf",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {},
            "age": "Although elves reach physical maturity at about the same age as humans, the elven understanding of adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims adulthood and an adult name around the age of 100 and can live to be 750 years old.",
            "alignment": "Elves love freedom, variety, and self-expression, so they lean strongly toward the gentler aspects of chaos. They value and protect others' freedom as well as their own, and they are more often good than not. The drow are an exception; their exile has made them vicious and dangerous. Drow are more often evil than not.",
            "size": "Medium",
            "size_description": "Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.",
            "starting_proficiencies": [
                {
                    "url": "http://www.dnd5eapi.co/api/proficiencies/116",
                    "name": "Skill: Perception"
                }
            ],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/3",
                    "name": "Elvish"
                }
            ],
            "language_options": {

            },
            "language_desc": "You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires.",
            "traits": [
                {
                    "name": "Darkvision (Elf)",
                    "url": "http://www.dnd5eapi.co/api/traits/5"
                },
                {
                    "name": "Fey Ancestry",
                    "url": "http://www.dnd5eapi.co/api/traits/6"
                },
                {
                    "name": "Trance",
                    "url": "http://www.dnd5eapi.co/api/traits/7"
                }
            ],
            "subraces": [
                {
                    "url": "http://www.dnd5eapi.co/api/subraces/2",
                    "name": "High Elf"
                }
            ],
            "url": "http://www.dnd5eapi.co/api/races/2"
        },
        {
            "index": 3,
            "name": "Halfling",
            "speed": 25,
            "ability_bonuses": [
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {},
            "age": "A halfling reaches adulthood at the age of 20 and generally lives into the middle of his or her second century.",
            "alignment": "Most halflings are lawful good. As a rule, they are good-hearted and kind, hate to see others in pain, and have no tolerance for oppression. They are also very orderly and traditional, leaning heavily on the support of their community and the comfort of their old ways.",
            "size": "Small",
            "size_description": "Halflings average about 3 feet tall and weigh about 40 pounds. Your size is Small.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/7",
                    "name": "Halfling"
                }
            ],
            "language_options": {},
            "language_desc": "You can speak, read, and write Common and Halfling. The Halfling language isn't secret, but halflings are loath to share it with others. They write very little, so they don't have a rich body of literature. Their oral tradition, however, is very strong. Almost all halflings speak Common to converse with the people in whose lands they dwell or through which they are traveling.",
            "traits": [
                {
                    "name": "Brave",
                    "url": "http://www.dnd5eapi.co/api/traits/21"
                },
                {
                    "name": "Halfling Nimbleness",
                    "url": "http://www.dnd5eapi.co/api/traits/22"
                },
                {
                    "name": "Lucky",
                    "url": "http://www.dnd5eapi.co/api/traits/23"
                }
            ],
            "subraces": [
                {
                    "url": "http://www.dnd5eapi.co/api/subraces/3",
                    "name": "Lightfoot Halfling"
                }
            ],
            "url": "http://www.dnd5eapi.co/api/races/3"
        },
        {
            "index": 4,
            "name": "Human",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1",
                    "bonus": 1
                },
                {
                    "name": "DEX",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/2",
                    "bonus": 1
                },
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3",
                    "bonus": 1
                },
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4",
                    "bonus": 1
                },
                {
                    "name": "WIS",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/5",
                    "bonus": 1
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6",
                    "bonus": 1
                }
            ],
            "ability_bonus_options": {},
            "age": "Humans reach adulthood in their late teens and live less than a century.",
            "alignment": "Humans tend toward no particular alignment. The best and the worst are found among them.",
            "size": "Medium",
            "size_description": "Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                }
            ],
            "language_options": {
                "choose": 1,
                "type": "languages",
                "from": [
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/2",
                        "name": "Dwarvish"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/3",
                        "name": "Elvish"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/4",
                        "name": "Giant"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/5",
                        "name": "Gnomish"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/6",
                        "name": "Goblin"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/7",
                        "name": "Halfling"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/8",
                        "name": "Orc"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/9",
                        "name": "Abyssal"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/10",
                        "name": "Celestial"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/11",
                        "name": "Draconic"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/12",
                        "name": "Deep Speech"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/13",
                        "name": "Infernal"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/14",
                        "name": "Primordial"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/15",
                        "name": "Sylvan"
                    },
                    {
                        "url": "http://www.dnd5eapi.co/api/languages/16",
                        "name": "Undercommon"
                    }
                ]
            },
            "language_desc": "You can speak, read, and write Common and one extra language of your choice. Humans typically learn the languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish military phrases, and so on.",
            "traits": [],
            "subraces": [],
            "url": "http://www.dnd5eapi.co/api/races/4"
        },
        {
            "index": 5,
            "name": "Dragonborn",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1",
                    "bonus": 2
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6",
                    "bonus": 1
                }
            ],
            "ability_bonus_options": {},
            "alignment": " Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil. Most dragonborn are good, but those who side with evil can be terrible villains.",
            "age": "Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach adulthood by 15. They live to be around 80.",
            "size": "Medium",
            "size_description": "Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds. Your size is Medium.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/11",
                    "name": "Draconic"
                }
            ],
            "language_options": {

            },
            "language_desc": "You can speak, read, and write Common and Draconic. Draconic is thought to be one of the oldest languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.",
            "traits": [
                {
                    "name": "Draconic Ancestry",
                    "url": "http://www.dnd5eapi.co/api/traits/24"
                },
                {
                    "name": "Breath Weapon",
                    "url": "http://www.dnd5eapi.co/api/traits/25"
                },
                {
                    "name": "Damage Resistance (Dragonborn)",
                    "url": "http://www.dnd5eapi.co/api/traits/18"
                }

            ],
            "trait_options":
                {
                    "choose": 1,
                    "from": [
                        {
                            "name": "Breath Weapon (Black)",
                            "url": "http://www.dnd5eapi.co/api/traits/26"
                        },
                        {
                            "name": "Breath Weapon (Blue)",
                            "url": "http://www.dnd5eapi.co/api/traits/27"
                        },
                        {
                            "name": "Breath Weapon (Brass)",
                            "url": "http://www.dnd5eapi.co/api/traits/28"
                        },
                        {
                            "name": "Breath Weapon (Bronze)",
                            "url": "http://www.dnd5eapi.co/api/traits/29"
                        },
                        {
                            "name": "Breath Weapon (Copper)",
                            "url": "http://www.dnd5eapi.co/api/traits/30"
                        },
                        {
                            "name": "Breath Weapon (Gold)",
                            "url": "http://www.dnd5eapi.co/api/traits/31"
                        },
                        {
                            "name": "Breath Weapon (Green)",
                            "url": "http://www.dnd5eapi.co/api/traits/32"
                        },
                        {
                            "name": "Breath Weapon (Red)",
                            "url": "http://www.dnd5eapi.co/api/traits/33"
                        },
                        {
                            "name": "Breath Weapon (Silver)",
                            "url": "http://www.dnd5eapi.co/api/traits/34"
                        },
                        {
                            "name": "Breath Weapon (White)",
                            "url": "http://www.dnd5eapi.co/api/traits/35"
                        }
                    ],
                    "type": "trait"
                },
            "subraces": [],
            "url": "http://www.dnd5eapi.co/api/races/5"
        },
        {
            "index": 6,
            "name": "Gnome",
            "speed": 25,
            "ability_bonuses": [
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {},
            "alignment": "Gnomes are most often good. Those who tend toward law are sages, engineers, researchers, scholars, investigators, or inventors. Those who tend toward chaos are minstrels, tricksters, wanderers, or fanciful jewelers. Gnomes are good-hearted, and even the tricksters among them are more playful than vicious.",
            "age": " Gnomes mature at the same rate humans do, and most are expected to settle down into an adult life by around age 40. They can live 350 to almost 500 years.",
            "size": "Small",
            "size_description": "Gnomes are between 3 and 4 feet tall and average about 40 pounds. Your size is Small.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/5",
                    "name": "Gnomish"
                }
            ],
            "language_options": {},
            "language_desc": "You can speak, read, and write Common and Gnomish. The Gnomish language, which uses the Dwarvish script, is renowned for its technical treatises and its catalogs of knowledge about the natural world.",
            "traits": [
                {
                    "name": "Darkvision",
                    "url": "http://www.dnd5eapi.co/api/traits/1"
                },
                {
                    "name": "Gnome Cunning",
                    "url": "http://www.dnd5eapi.co/api/traits/19"
                }
            ],
            "trait_options": {},
            "subraces": [
                {
                    "url": "http://www.dnd5eapi.co/api/subraces/4",
                    "name": "Rock Gnome"
                }
            ],
            "url": "http://www.dnd5eapi.co/api/races/6"
        },
        {
            "index": 7,
            "name": "Half-Elf",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {
                "choose": 2,
                "type": "ability_bonuses",
                "from": [
                    {
                        "name": "STR",
                        "url": "http://www.dnd5eapi.co/api/ability-scores/1",
                        "bonus": 1
                    },
                    {
                        "name": "DEX",
                        "url": "http://www.dnd5eapi.co/api/ability-scores/2",
                        "bonus": 1
                    },
                    {
                        "name": "CON",
                        "url": "http://www.dnd5eapi.co/api/ability-scores/3",
                        "bonus": 1
                    },
                    {
                        "name": "INT",
                        "url": "http://www.dnd5eapi.co/api/ability-scores/4",
                        "bonus": 1
                    },
                    {
                        "name": "WIS",
                        "url": "http://www.dnd5eapi.co/api/ability-scores/5",
                        "bonus": 1
                    }
                ]
            },
            "alignment": "Half-elves share the chaotic bent of their elven heritage. They value both personal freedom and creative expression, demonstrating neither love of leaders nor desire for followers. They chafe at rules, resent others' demands, and sometimes prove unreliable, or at least unpredictable.",
            "age": "Half-elves mature at the same rate humans do and reach adulthood around the age of 20. They live much longer than humans, however, often exceeding 180 years.",
            "size": "Medium",
            "size_description": "Half-elves are about the same size as humans, ranging from 5 to 6 feet tall. Your size is Medium.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "name": "Common",
                    "url": "http://www.dnd5eapi.co/api/languages/1"
                },
                {
                    "name": "Elvish",
                    "url": "http://www.dnd5eapi.co/api/languages/3"
                }
            ],
            "language_options": {
                "choose": 1,
                "type": "languages",
                "from": [
                    {
                        "name":"Dwarvish",
                        "url":"http://www.dnd5eapi.co/api/languages/2"
                    },
                    {
                        "name":"Giant",
                        "url":"http://www.dnd5eapi.co/api/languages/4"
                    },
                    {
                        "name":"Gnomish",
                        "url":"http://www.dnd5eapi.co/api/languages/5"
                    },
                    {
                        "name":"Goblin",
                        "url":"http://www.dnd5eapi.co/api/languages/6"
                    },
                    {
                        "name":"Halfling",
                        "url":"http://www.dnd5eapi.co/api/languages/7"
                    },
                    {
                        "name":"Orc",
                        "url":"http://www.dnd5eapi.co/api/languages/8"
                    },
                    {
                        "name":"Abyssal",
                        "url":"http://www.dnd5eapi.co/api/languages/9"
                    },
                    {
                        "name":"Celestial",
                        "url":"http://www.dnd5eapi.co/api/languages/10"
                    },
                    {
                        "name":"Draconic",
                        "url":"http://www.dnd5eapi.co/api/languages/11"
                    },
                    {
                        "name":"Deep Speech",
                        "url":"http://www.dnd5eapi.co/api/languages/12"
                    },
                    {
                        "name":"Infernal",
                        "url":"http://www.dnd5eapi.co/api/languages/13"
                    },
                    {
                        "name":"Primordial",
                        "url":"http://www.dnd5eapi.co/api/languages/14"
                    },
                    {
                        "name":"Sylvan",
                        "url":"http://www.dnd5eapi.co/api/languages/15"
                    },
                    {
                        "name":"Undercommon",
                        "url":"http://www.dnd5eapi.co/api/languages/16"
                    }
                ]
            },
            "language_desc": "You can speak, read, and write Common, Elvish, and one extra language of your choice.",
            "traits": [
                {
                    "name": "Darkvision (Half-Elf)",
                    "url": "http://www.dnd5eapi.co/api/traits/48"
                },
                {
                    "name": "Fey Ancestry",
                    "url": "http://www.dnd5eapi.co/api/traits/49"
                },
                {
                    "name": "Skill Versatility",
                    "url": "http://www.dnd5eapi.co/api/traits/50"
                }

            ],
            "trait_options": {},
            "subraces": [],
            "url": "http://www.dnd5eapi.co/api/races/7"
        },
        {
            "index": 8,
            "name": "Half-Orc",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "STR",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/1",
                    "bonus": 2
                },
                {
                    "name": "CON",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/3",
                    "bonus": 1
                }
            ],
            "ability_bonus_options": {},
            "alignment": " Half-orcs inherit a tendency toward chaos from their orc parents and are not strongly inclined toward good. Half-orcs raised among orcs and willing to live out their lives among them are usually evil.",
            "age": "Half-orcs mature a little faster than humans, reaching adulthood around age 14. They age noticeably faster and rarely live longer than 75 years.",
            "size": "Medium",
            "size_description": "Half-orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall. Your size is Medium.",
            "starting_proficiencies": [
                {
                    "name": "Skill: Intimidation",
                    "url": "http://www.dnd5eapi.co/api/proficiencies/112"
                }
            ],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/8",
                    "name": "Orcish"
                }
            ],
            "language_options": {},
            "language_desc": "You can speak, read, and write Common and Orc. Orc is a harsh, grating language with hard consonants. It has no script of its own but is written in the Dwarvish script.",
            "traits": [
                {
                    "name": "Darkvision (Half-Orc)",
                    "url": "http://www.dnd5eapi.co/api/traits/51"
                },
                {
                    "name": "Savage Attacks",
                    "url": "http://www.dnd5eapi.co/api/traits/52"
                },
                {
                    "name": "Restless Endurance",
                    "url": "http://www.dnd5eapi.co/api/traits/53"
                }

            ],
            "trait_options": {},
            "subraces": [],
            "url": "http://www.dnd5eapi.co/api/races/8"
        },
        {
            "index": 9,
            "name": "Tiefling",
            "speed": 30,
            "ability_bonuses": [
                {
                    "name": "INT",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/4",
                    "bonus": 1
                },
                {
                    "name": "CHA",
                    "url": "http://www.dnd5eapi.co/api/ability-scores/6",
                    "bonus": 2
                }
            ],
            "ability_bonus_options": {},
            "alignment": "Tieflings might not have an innate tendency toward evil, but many of them end up there. Evil or not, an independent nature inclines many tieflings toward a chaotic alignment.",
            "age": "Tieflings mature at the same rate as humans but live a few years longer.",
            "size": "Medium",
            "size_description": "Tieflings are about the same size and build as humans. Your size is Medium.",
            "starting_proficiencies": [],
            "starting_proficiency_options": {},
            "languages": [
                {
                    "url": "http://www.dnd5eapi.co/api/languages/1",
                    "name": "Common"
                },
                {
                    "url": "http://www.dnd5eapi.co/api/languages/9",
                    "name": "Infernal"
                }
            ],
            "language_options": {},
            "language_desc": "You can speak, read, and write Common and Infernal.",
            "traits": [
                {
                    "name": "Darkvision (Tiefling)",
                    "url": "http://www.dnd5eapi.co/api/traits/54"
                },
                {
                    "name": "Hellish Resistance",
                    "url": "http://www.dnd5eapi.co/api/traits/55"
                },
                {
                    "name": "Infernal Legacy",
                    "url": "http://www.dnd5eapi.co/api/traits/56"
                }
            ],
            "trait_options": {},
            "subraces": [],
            "url": "http://www.dnd5eapi.co/api/races/9"
        }
    ]"""

