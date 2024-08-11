import axios from "axios";
import { AboutDetail } from "../Models/AboutDetail";

export default class AboutVM {
  public aboutDetails = new AboutDetail();

  // Initialise the view model when About.tsx is instantiated.
  public async initialise() {
    await this.getAboutDetailsAsync();
  }

  // Get the about details from the API.
  private async getAboutDetailsAsync() {
    const result = await (await axios.get("http://localhost:8080/api/about/details")).data;
    this.aboutDetails = result;
    console.log(this.aboutDetails);
  }
}
