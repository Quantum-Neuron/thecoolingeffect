import React from "react";
import { Button, Card } from "react-bootstrap";
import { NavLink } from "react-router-dom";

export default class Homepage extends React.Component {
	render() {
		return (
			<div className="container">
				<Card className="text-center">
					<Card.Header>The Cooling Effect.</Card.Header>
					<Card.Body>
						<Card.Title>Welcome to where things get a little bit icy.</Card.Title>
						<Card.Text>
							We are you're all rounder solution to helping you cooldown from those heated moments.
						</Card.Text>
						<NavLink to="/about">
							<Button variant="primary" size="lg">
								About
							</Button>
						</NavLink>
					</Card.Body>
				</Card>
			</div>
		);
	}
}
