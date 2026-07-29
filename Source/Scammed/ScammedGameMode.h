// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ScammedGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AScammedGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AScammedGameMode();
};



