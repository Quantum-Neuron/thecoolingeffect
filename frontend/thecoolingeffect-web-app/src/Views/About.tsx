import { Component } from "react";
import AboutVM from "./AboutVM";
import { Card, Form } from "react-bootstrap";
import { AboutDetail } from "../Models/AboutDetail";

export interface AboutVMProps {
  viewModel: AboutVM;
  AboutDetails: AboutDetail;
}

export default class About extends Component<AboutVMProps> {
  constructor(props: AboutVMProps) {
    super(props);
    this.props.viewModel.initialise();
  }

  render() {
    return (
    <>
      <Card>
        <Form>
          <Form.Group className="mb-3">
            <Form.Control value={this.props.viewModel.aboutDetails.firstName} disabled={true} />
          </Form.Group>
        </Form>
      </Card>
    </>
  );
  }
}
