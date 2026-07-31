// Fill out your copyright notice in the Description page of Project Settings.


#include "SCGameMode.h"

// Nombre de scammers en fonction du nombre de joueurs
UPROPERTY(EditDefaultsOnly, Category = "SCAMMED")
TMap<int32, int32> ScammerCountByPlayerCount;

// Rôles attribués : clé = PlayerState, valeur = rôle
TMap<APlayerState*, FName> PlayerRoles;

// Fonction d'attribution des rôles
void AssignRoles();

