import { Component } from "react";
import AboutVM from "./AboutVM";
import { Card, Form, FormGroup } from "react-bootstrap";

export default class About extends Component {
  private aboutVM: AboutVM;

  constructor(props: any) {
    super(props);
    this.aboutVM = new AboutVM();
  }

  render() {
    // const { viewModel } = this.aboutVM;

    return (
    <>
      <Card>
        <Form>
          <FormGroup>
          </FormGroup>
        </Form>
      </Card>
    </>
  );
  }
}
