import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CharacterComponent } from './Character/character/character.component'
import { QuestsComponent } from './Quests/quests/quests.component'

const routes: Routes = [ 
  { path: '', component: CharacterComponent },
  { path: 'character', component: CharacterComponent },
  { path: 'quests', component: QuestsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
