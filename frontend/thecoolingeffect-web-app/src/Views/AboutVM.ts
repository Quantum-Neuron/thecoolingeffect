import axios from "axios";
import { AboutDetail } from "../Models/AboutDetail";

export default class AboutVM {
  public aboutDetails = new AboutDetail();

  public async initialise() {
    await this.getAboutDetailsAsync();
  }

  private async getAboutDetailsAsync() {
    const result = await (await axios.get("https://localhost:8080/api/about/details"))
      .data;
    this.aboutDetails = result;
    console.log(this.aboutDetails);
  }
}
