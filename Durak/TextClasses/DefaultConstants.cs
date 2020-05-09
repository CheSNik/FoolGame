﻿using System;
using Durak.Interfaces;

namespace Durak.TextClasses
{
    public class DefaultConstants : IDefaultConstants
    {
        public int numberOfCards_1_ { get; }
        public string strategy_1_4_ { get; }
        public string strategy_2_5_ { get; }
        public string strategy_Human_6_ { get; }
        public string WantToContinue_7_ { get; }

        public DefaultConstants(ILanguageDataProvider languageConfiguration)
        {
            if (languageConfiguration != null)
            {
                strategy_1_4_ = languageConfiguration.GetTextFromConfiguration("strategy_1_4_");
                strategy_2_5_ = languageConfiguration.GetTextFromConfiguration("strategy_2_5_");
                strategy_Human_6_ = languageConfiguration.GetTextFromConfiguration("strategy_Human_6_");
                WantToContinue_7_ = languageConfiguration.GetTextFromConfiguration("WantToContinue_7_");
                int.TryParse(languageConfiguration.GetTextFromConfiguration("numberOfCards_1_"), out int numberOfCards);
                numberOfCards_1_ = numberOfCards;
            }
            else
            {
                throw new ArgumentNullException(nameof(DefaultConstants));
            }
        }

    }
}
