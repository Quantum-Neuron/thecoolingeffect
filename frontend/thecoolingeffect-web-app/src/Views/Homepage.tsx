import React from "react";
import { Button } from "react-bootstrap";
import { NavLink } from "react-router-dom";

export default class Homepage extends React.Component {
	render() {
		return (
			<div className="container">
				<div>
					<h1>Homepage</h1>
				</div>
				<NavLink to="/about">
					<Button variant="primary" size="lg" />
				</NavLink>
			</div>
		);
	}
}
