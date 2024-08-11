import React from "react";
import { Button, Card } from "react-bootstrap";
import { NavLink } from "react-router-dom";
import { MDBContainer } from "mdb-react-ui-kit";
import tinyToiletGif from "../Images/curse-you-tiny-toilet.gif";

const Homepage: React.FC = () => {
	return (
		<div className="container">
			<Card className="text-center shadow">
				<Card.Header>
					<h1>The Cooling Effect.</h1>
				</Card.Header>
				<Card.Body>
					<Card.Title>Welcome to where things get a little bit icy.</Card.Title>
					<Card.Text>
						We are your all-rounder solution to helping you cool down from those
						heated moments.
					</Card.Text>
					<MDBContainer>
						<iframe
							width="100%"
							height="315"
							src="https://www.youtube.com/embed/f_Pcu6wTzoA?si=wNFUyTNe6J7WHsKT?autoplay=1&mute=1"
							title="Spooderman"
							allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
						/>
					</MDBContainer>
					<NavLink to="/about">
						<Button className="mt-4" variant="primary" size="lg">
							About
						</Button>
					</NavLink>
				</Card.Body>
				<Card.Footer>
					<p>Copyright - What do you mean.</p>
				</Card.Footer>
			</Card>
		</div>
	);
};

export default Homepage;
