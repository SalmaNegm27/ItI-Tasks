import { Component } from '@angular/core';

@Component({
  selector: 'app-selectors',
  templateUrl: './selectors.component.html',
  styleUrls: ['./selectors.component.css']
})
export class SelectorsComponent {
  // branches = [
  //   { name: "donet", branches: ["New Cairo", "Alex", "Assuit", "Mansoura"] },
  //   { name: "os", branches: ["Alex"] },
  //   { name: "pd", branches: ["Cairo", "Alex", "Assuit", "Smart"] },
  //   { name: "motion", branches: ["Qena", "Sohag"] },
  //   { name: "meanstack", branches: ["Mansora", "Smart"] },
  //   { name: "mearn", branches: ["New Cairo", "Alex", "Assuit", "Mansoura"] },
  //   { name: "frontend", branches: ["Smart"] },
  // ];

  // selectedTrack: string = "";

  // onTrackSelected(trackName: string) {
  //   this.selectedTrack = trackName;
  // }

  selectedTrack: string="";
  newList: string[] = [];

  updateNewList(): void {
    // Clear the existing new list
    this.newList = [];

    // Add options to the new list based on the selectedTrack value
    if (this.selectedTrack === 'donet') {
      this.newList.push('Alex', 'Cairo', 'Smart');
    } else if (this.selectedTrack === 'os') {
      this.newList.push('Mansora');
    } else if (this.selectedTrack === 'pd') {
      this.newList.push('Assuit', 'Qena');
    }
    else if (this.selectedTrack === 'motion') {
      this.newList.push('Alex', 'Mansoura', 'New Cairo','Sohag');
    }
    else if (this.selectedTrack === 'meanstack') {
      this.newList.push('Qena','Alex');
    }
    else if (this.selectedTrack === 'mearn') {
      this.newList.push('Mansoura', 'New Cairo',);
    }
    else if (this.selectedTrack === 'frontend') {
      this.newList.push('New Cairo',);
    }
  }

  }

