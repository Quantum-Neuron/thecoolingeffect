import React from "react";
import { Button } from "react-bootstrap";
import { useNavigate } from "react-router-dom";

const AboutPageButton: React.FC = () => {
	const navigate = useNavigate();

	const goToAbout = () => {
		navigate("/about");
	};

	return (
		<React.Fragment>
			<Button size="lg" value="About" onClick={goToAbout} />
		</React.Fragment>
	);
};

export default class Homepage extends React.Component {
	render() {
		return (
			<>
				<h1>Homepage</h1>
				<AboutPageButton />
			</>
		);
	}
}
