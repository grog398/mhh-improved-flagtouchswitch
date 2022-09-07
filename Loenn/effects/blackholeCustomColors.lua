﻿local effect = {}

effect.name = "MaxHelpingHand/BlackholeCustomColors"
effect.canBackground = true
effect.canForeground = true

effect.fieldInformation = {
    bgColorInner = {
        fieldType = "color"
    },
    bgColorOuterMild = {
        fieldType = "color"
    },
    bgColorOuterWild = {
        fieldType = "color"
    }
}

effect.defaultData = {
    colorsMild = "6e3199,851f91,3026b0",
    colorsWild = "ca4ca7,b14cca,ca4ca7",
    bgColorInner = "000000",
    bgColorOuterMild = "512a8b",
    bgColorOuterWild = "bd2192",
    alpha = 1.0,
    affectedByWind = true,
    fadex = "",
    fadey = "",
    direction = 1.0,
    additionalWindX = 0.0,
    additionalWindY = 0.0
}

return effect