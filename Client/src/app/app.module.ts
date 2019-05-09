import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharacterComponent } from './Character/character/character.component';
import { SkillsComponent } from './Character/Components/skills/skills.component';
import { AbilitiesComponent } from './Character/Components/abilities/abilities.component';
import { InformationComponent } from './Character/Components/information/information.component';
import { ContributionPointsComponent } from './Character/Components/contribution-points/contribution-points.component';
import { StatsComponent } from './Character/Components/stats/stats.component';
import { HistoryComponent } from './Character/Components/history/history.component';
import { HealthBarsComponent } from './Character/Components/health-bars/health-bars.component';

@NgModule({
  declarations: [
    AppComponent,
    CharacterComponent,
    SkillsComponent,
    AbilitiesComponent,
    InformationComponent,
    ContributionPointsComponent,
    StatsComponent,
    HistoryComponent,
    HealthBarsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
