import { Component, useEffect, useState } from "react";
import AboutVM from "./AboutVM";
import { Card, Form, Spinner } from "react-bootstrap";
import { AboutDetail } from "../Models/AboutDetail";
import tinyToiletGif from "../Images/curse-you-tiny-toilet.gif";

export interface AboutVMProps {
  viewModel: AboutVM;
}

const About: React.FC<AboutVMProps> = ({ viewModel }) => {
  const [loading, setLoading] = useState(true);
  const [data, setData] = useState<AboutDetail | null>(null);

  // Display a loading message while About details are being fetched.
  useEffect(() => {
    const fetchData = async () => {
      await viewModel.initialise();
      setData(viewModel.aboutDetails!);
      setLoading(false);
    };
    fetchData();
  }, [viewModel]);

  if (loading) {
    return <Spinner animation="grow" variant="light" />
  }

  return (
    <Card className="text-center shadow">
      <Card.Header><h1>About</h1></Card.Header>
      <Card.Body>
        <Card.Title>
          This is about some guy called <strong>{data?.firstName}</strong>
          ... not to be mistaken for the Rock Johnson.
        </Card.Title>
        <Card.Text>
          If rumors are to be believed his surname is <strong>{data?.lastName}</strong>.
          Apparently if you look very closely in the footer you'll find his jokes...
          They are not very good.
        </Card.Text>
      </Card.Body>
      <Card.Footer>
        Here is a little joke for you: <strong>{data?.joke}</strong>
        <img className="mt-3" src={tinyToiletGif} />
      </Card.Footer>
    </Card>
  );
}

export default About;
